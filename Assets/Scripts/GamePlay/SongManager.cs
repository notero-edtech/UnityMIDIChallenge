using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
// using Melanchall.DryWetMidi.Core;
// using Melanchall.DryWetMidi.Interaction;
using MidiPlayerTK;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class SongManager : MonoBehaviour
{
    public static SongManager Instance { get; private set; }

    // [SerializeField]
    // private AudioSource audioSource;
    // [SerializeField]
    // private float songDelayInSeconds;
    // public double marginOfError; // in seconds
    // public int inputDelayInMilliseconds;
    // [SerializeField]
    // private string midiFileLocation;
    public float noteSpeed; //the speed of note in the song

    // public float noteTime; //time that note will be on screen
    // public float audioTime; //time that note will be on screen
    public float playerNoteSpeed; //the note's speed that player want. Default equal song's speed

    // public float songDuration; //time that note will be on screen
    public List<KeyCode> currentKeyPressedList = new List<KeyCode>();

    [SerializeField]
    private List<KeyCode> keysCanPressed = new List<KeyCode>();

    [SerializeField]
    private List<AudioClip> buttonSounds = new List<AudioClip>();

    [SerializeField]
    private AudioSource audioSource;

    // public float noteSpawnY;
    // [SerializeField]
    // private float noteTapY;
    // public float noteDespawnY
    // {
    //     get
    //     {
    //         return noteTapY - (noteSpawnY - noteTapY);
    //     }
    // }
    // public static MidiFile midiFile;
    private MidiFilePlayer midiFilePlayer;

    [SerializeField]
    private List<GameObject> notePrefabs = new List<GameObject>();

    // [SerializeField]
    // private List<int> noteValues = new List<int>();
    [SerializeField]
    private List<Transform> lanes = new List<Transform>();

    [SerializeField]
    private List<TMP_Text> keyText = new List<TMP_Text>();

    // [SerializeField]
    // private Lane[] lanes;
    private void Start()
    {
        Instance = this;
        midiFilePlayer = FindObjectOfType<MidiFilePlayer>();
        midiFilePlayer.OnEventNotesMidi.AddListener (NoteActions);
        playerNoteSpeed = midiFilePlayer.MPTK_Speed;
        SetKeyCanPressed();
    }

    private void SetKeyCanPressed()
    {
        foreach (GameObject note in notePrefabs)
        {
            keysCanPressed.Add(note.GetComponent<Note>().noteKeyCode);
        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            if (!SongManager.Instance.currentKeyPressedList.Contains(e.keyCode))
            {
                SongManager.Instance.currentKeyPressedList.Add(e.keyCode);
                for (int i = 0; i < keysCanPressed.Count; i++)
                {
                    if (e.keyCode == keysCanPressed[i])
                    {
                        keyText[i].color = Color.black;
                        audioSource.clip = buttonSounds[i];
                        audioSource.Play();
                    }
                }
            }

            // foreach (KeyCode key in keyValues)
            // {
            //     if (e.keyCode == key && !currentKeyPressedList.Contains(key))
            //     {
            //         currentKeyPressedList.Add (key);
            //     }
            // }
        }
        if (e.type == EventType.KeyUp)
        {
            if (SongManager.Instance.currentKeyPressedList.Contains(e.keyCode))
            {
                SongManager.Instance.currentKeyPressedList.Remove(e.keyCode);
                for (int i = 0; i < keysCanPressed.Count; i++)
                {
                    if (e.keyCode == keysCanPressed[i])
                    {
                        keyText[i].color = Color.white;
                    }
                }
            }

            // foreach (KeyCode key in keyValues)
            // {
            //     if (e.keyCode == key && currentKeyPressedList.Contains(key))
            //     {
            //         currentKeyPressedList.Remove (key);
            //     }
            // }
        }
    }

    public void NoteActions(List<MPTKEvent> mptkEvents)
    {
        foreach (MPTKEvent note in mptkEvents)
        {
            if (note.Command == MPTKCommand.NoteOn)
            {
                // if the note is being played
                int noteValue = note.Value; // get the note value

                // string noteLabel = HelperNoteLabel.LabelFromMidi(noteValue); // get the note label
                // noteTime = note.Duration; // get the note duration
                // noteTime = note.Duration; // get the note duration
                noteSpeed = note.Velocity;

                // expectedNoteSpeed = midiFilePlayer.MPTK_Speed;
                // audioTime = note.RealTime;
                SpawnNote (noteValue);

                // songDuration = midiFilePlayer.MPTK_DurationMS;
                // Debug.Log($"song speed: {midiFilePlayer.MPTK_Speed}");
                // char noteOctave = noteLabel[1]; // get the octave of the note
                // GameObject octaveModel = GameObject.Find("octave" + noteOctave); // get the correct octave gameobject
                // float volume = note.Velocity; // get the note velocity

                // Debug.Log($" timeSinceSpawned : {timeSinceSpawned}");
                // Debug.Log($" Velocity : {volume}");
            }
        }
    }

    private void SpawnNote(int noteValue)
    {
        for (int i = 0; i < notePrefabs.Count; i++)
        {
            if (noteValue == notePrefabs[i].GetComponent<Note>().noteValue)
            {
                Instantiate(notePrefabs[i],
                lanes[i].position,
                notePrefabs[i].transform.rotation);
            }
        }
        // for (int i = 0; i < noteValues.Count; i++)
        // {
        //     if (noteValue == noteValues[i])
        //     {
        //         Instantiate(notePrefabs[i],
        //         lanes[i].position,
        //         notePrefabs[i].transform.rotation);
        //     }
        // }
    }

    private void Update()
    {
    }
    // private void ReadFromFile()
    // {
    //     midiFile =
    //         MidiFile
    //             .Read(Application.streamingAssetsPath + "/" + midiFileLocation);
    //     GetDataFromMidi();
    // }
    // private void GetDataFromMidi()
    // {
    //     // var notes = midiFile.GetNotes();
    //     var notes = midiFile.Notes;
    //     var array = new Melanchall.DryWetMidi.Interaction.Note[notes.Count];
    //     notes.CopyTo(array, 0);
    //     foreach (var lane in lanes)
    //     {
    //         lane.GetComponent<Lane>().SetTimeStamps(array);
    //     }
    //     Invoke(nameof(StartSong), songDelayInSeconds);
    // }
    // private void StartSong()
    // {
    //     audioSource.Play();
    // }
    // public static double GetAudioSourceTime()
    // {
    //     return (double) Instance.audioSource.timeSamples /
    //     Instance.audioSource.clip.frequency;
    // }
}