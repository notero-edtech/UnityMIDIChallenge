using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;

namespace PopNathakorn.UI.Demo
{
    public class GenerateNoteFromMidiDemo : MonoBehaviour
    {
        #region UI Components
        [Header("UI Components")]
        [SerializeField]
        private NoteGenerator noteGenerator;
        #endregion

        #region Audio Components
        [Header("Audio Components")]
        [SerializeField]
        private AudioSource audioSource;
        #endregion

        #region Prefabs
        [Header("Prefabs")]
        [SerializeField]
        private NoteLane originalNoteLane;
        #endregion

        #region Settings
        [Header("Settings")]
        [SerializeField]
        private RectTransform noteLaneGroup;
        [SerializeField]
        private LevelConfiguration levelConfiguration;
        #endregion

        private List<NoteLane> noteLanes;
        IEnumerator playRoutine;

        float time => Time.time;

        private void Awake()
        {
            // Read a MIDI file
            var midiFile = MidiFile.Read(levelConfiguration.Music.MidiFilePath);
            var midiTracks = midiFile.GetTrackChunks().ToList();

            TempoMap tempoMap = midiFile.GetTempoMap();

            noteLanes = new List<NoteLane>();
            foreach(var noteLaneConfig in levelConfiguration.NoteLanes)
            {
                // Get notes ordered by time where channel and midi value same as configuration
                using NotesManager notesManager = midiTracks[noteLaneConfig.Track].ManageNotes();
                var notes = notesManager.Notes.Where(note => note.Channel == noteLaneConfig.Channel && note.NoteNumber == noteLaneConfig.MidiValue);
                var noteSequence = new NotesCollectionAdapter(notes, tempoMap);
                noteSequence.TimeToReachHitPosition = levelConfiguration.TimeToReachHitPosition;

                var noteLaneObject = Instantiate(originalNoteLane, noteLaneGroup, false);
                var noteLane = noteLaneObject.GetComponent<NoteLane>();
                noteLane.InputKey = noteLaneConfig.InputKey;
                noteLane.Color = noteLaneConfig.Color;
                noteLane.NoteGenerator = noteGenerator;
                noteLane.NoteSequence = noteSequence;

                noteLanes.Add(noteLane);
            }
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
                PlayAudioClip();
            if(Input.GetKeyDown(KeyCode.Alpha2))
                LaunchNotes();
            if(Input.GetKeyDown(KeyCode.Space))
                Play();
        }

        private void PlayAudioClip()
        {
            audioSource.PlayOneShot(levelConfiguration.Music.AudioClip);
        }

        private void LaunchNotes()
        {
            foreach(var lane in noteLanes)
                lane.Launch();
        }

        private void Play()
        {
            if(playRoutine != null)
                return;

            playRoutine = PlayRoutine();
            StartCoroutine(playRoutine);
        }

        IEnumerator PlayRoutine()
        {
            LaunchNotes();
            yield return new WaitForSeconds(levelConfiguration.TimeToReachHitPosition - levelConfiguration.Music.TimeOffet);
            PlayAudioClip();

            playRoutine = null;
        }
    }

    [Serializable]
    public struct LevelConfiguration
    {
        public MusicConfiguration Music;
        public List<NoteLaneConfiguration> NoteLanes;
        public float TimeToReachHitPosition;
    }

    [Serializable]
    public struct NoteLaneConfiguration
    {
        public KeyCode InputKey;
        public byte Track;
        public byte Channel;
        public byte MidiValue;
        public Color Color;
        public int ScorePoint;
    }

    [Serializable]
    public struct MusicConfiguration
    {
        /// <summary>
        /// Absolute path for midi file
        /// </summary>
        public string MidiFilePath;

        /// <summary>
        /// Audio clip
        /// </summary>
        public AudioClip AudioClip;

        /// <summary>
        /// How long of midi delay from music in seconds
        /// </summary>
        public float TimeOffet;
    }

    public class NotesCollectionAdapter : NoteSequence
    {
        public NotesCollectionAdapter(IEnumerable<Melanchall.DryWetMidi.Interaction.Note> notesCollection, TempoMap tempoMap)
        {
            foreach(var note in notesCollection)
            {
                var metricTimeOfNote = TimeConverter.ConvertTo<MetricTimeSpan>(note.Time, tempoMap);
                long timeInMicroseconds = metricTimeOfNote.TotalMicroseconds;
                float timeInSeconds = timeInMicroseconds / 1000000F;
                var noteData = new NoteData(timeInSeconds);
                Enqueue(noteData);
            }
        }
    }
}
