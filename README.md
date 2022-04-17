# UnityMIDIChallenge
This is the test of **Unity Developer** from **Mutex Team**. Test duration is **7 days** since this test has been received. It is a simple challenge for drawing a gameplay scene from a MIDI file using Unity engine(C#), please thoroughly read before the start.
> Unity engine version 2020.3.14f1

## Requirements
### Gameplay
- The game should contains only a single gameplay screen(no other screens)
- Total 6 note lines

| No. | Note | Sound     | MIDI value | Color  | Score point | Input key |
|-----|------|-----------|------------|--------|-------------|-----------|
| 1   | C#2  | rim snare | 37         | purple | 20          | A         |
| 2   | C#3  | cymbal    | 49         | blue   | 20          | S         |
| 3   | D2   | snare     | 38         | green  | 20          | D         |
| 4   | C2   | bass drum | 36         | yellow | 20          | F         |
| 5   | C3   | high tom  | 48         | orange | 20          | G         |
| 6   | G2   | floor tom | 43         | red    | 20          | H         |

 
- Player must press key on the keyboard in time when the scrolling notes collide with the note indicator
- For every note hit, it should increases the total score by `Score point` from the table
- For every note hit, note should be destroyed/hidden
- When complete a song, player can press `spacebar` to restart the game
- Speed of notes scrolling down is configurable
- Color of notes is configurable
- Size of notes is configurable(optional)
- Score point of notes is configurable
- Input key is configurable

### Game Visual
- Default screen size should be 1270 x 720 with responsive UI
- Displays key panel with input guide(A, S, D, F, G, H) on the bottom of the screen as gameplay screenshots
    - Each key display in its own color (see the color column in the table above)
    - Each key will display key-down feedback
- Displays the note indicator at the top of key panel
- Notes scroll down to the key in vertical in configured speed
    - The notes should be generated by the MIDI data from `DrumTrack1.mid` in `AssetData/Midi`
    - MIDI file is configurable
- Display total score on the top-left of the screen(for example: `Score: 500`)

### Sound
- Play MIDI song in time with scrolling notes using `DrumTrack1.mp3` in `AssetData/Sounds`
    - MIDI song is configurable as the MIDI file

### Additional Requirements
- Unit test is required
- UML Diagram is required, you can use any tools and techniques to create the diagram

## Limitation
- No Playmaker
- 3rd party libraries for **MIDI are allowed**, but others are not
- You can remove/create any files and folders if needed

## Art
- You can use .png file in `AssetData/Sprites` folder to create game sprites
- Game background can be any plain color
- Text can be any font you like

## Evaluation
- Completeness
- Architecture
- Data structures
- Time & memory complexity of algorithms
- Overall Performance
- Code readability
- Code cleanliness
- Unity engine usage
- Design principle, Diagram and Explanation

## Submission
Submit your test by creating PR to this repository
<!-- replace your link here -->
UML diagram: [link](https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&layers=1&nav=1&title=Rhythm%20Game.drawio#R7V3rc%2BK2Fv9rmNn7Acby2x%2BTsNnuNNmmJXvb2y87DjjgrrEY22xC%2F%2For2ZKxHn4AFtB7ndlpsTgWss7vPHUkj4y79funxN%2BsHuEiiEa6tngfGdORrtuu5aD%2F4ZZd0WJqmlG0LJNwUbSBfcMs%2FDsgjbR1Gy6ClCHMIIyycMM2zmEcB%2FOsaNOKNj9J4BtL9goj9lc3%2FjIQGmZzPxJbfw8X2YqOzvb2X%2FwUhMsV%2BWlXJ0%2B89ikxGU268hfwrdJkfBwZdwmEWfFp%2FX4XRHj26LwU993XfFsOLAnirMsNuwdj7hrZn%2FFrstF%2F%2FuuPnzUvG5NefvjRljzwLMiyMF6mI90e6QbQRsYtGX%2B2o5OSvoXryI%2FR1e0rjLMZ%2BQagaz8KlzH6PEejChLU8CNIshDN5w35IoMb1DpfhdHiwd%2FBLR57mvnz7%2FTqdgWT8G%2FUrR%2BRPtHXSUaggUZVpZjhO1EzHmYSpIjmiU4I4Joe%2FXeG8MFPM9Iwh1Hkb9LwpXyMtZ8sw%2FgWZhlcE6LXMIruYASTfA6MwAIIzPnoEvg9qHxzq2ta%2Fg2em0r7a%2F5XzmeVc5QNaK6C90oT4eSnAK6DLNkhEvLt2NCLW4hcGQSOb3uMIlkr2lYVeALPJrJB5GJZdr2HDvpA0HMAknQBSSP9FsNmDpPgCYb4UW9wJ%2BhDFVqY5gvMgtkmCBbocz3VIxonjNFwS6oXpAkEsu%2FB7g7poWmItAElxBchjH38nHaEQZb%2FAHpS7eeCHLUvs7wPrrs5ZmCXzrSC1WU%2FnMwgxmYV%2BYiC16xWOtKNP0cy%2BJDTTM19y2%2BEk7gJontfo1yjrMLFIogxsmHmZ34BY%2FwIGzzvOaetW%2FQPAeJOm1gja4qf3boF%2B2v0D5MnCLAxQrSf82saIBl5C7Cc1MK%2FDuT1YiHCv1E1tcsEkQHd7iYDrqlIBAyJCHAoiMJcaxaTQw0K4KY3hjlRC1TWiOlRsMfGM4bOdAwE%2FBgifgwJViL%2FJYieYBpicKO2pKDlMNQGE1XMBUDryF1FzDVr9Ns0ePW3UUbUyId%2FlWriB0T98dqEUOec7kj7b%2FyLAq1cuzTYohrx%2Fefqo87GtS8Aut0A6KhCoCUg8JO%2FDp4ifzc4aBKIa5rrH2ahNM1yaizU4Q6a6zEOmqVrE0%2FipDkSBOmeowhCdo0SW5ZAIkpmjyxOKT2jeQ8Qq%2FDsl9QLuMWc4Wn9ebZFCGAcO6QhfNG1C%2BPNNpsG1REIHuBs47%2FFyD61dIV9yccwTRt%2Fs%2Fw4Rl9jQdn3%2BoDFprB0LBmyt%2BEDnPu5eaTUCENIDXKUYbxAApXBpHm09fGVVJsTr%2BBwR%2BF6dXhHXW11Fr4GT1AmaMBS5Qo6gyuojLvAlbiCMvaqMsRujRYd3emjG60az87ewmy%2BanP0PgXZzXYRwhncJvPgOVxX3T2Jbq1TZKifKeLjfQLXj0hZ1f%2FsuBjpLDfbMF4e5V0O%2BugAxEp8R6lC0jxFmAWeAFqM0iHLd81OpGGYjBOpe97EEpAEHCBBkg0UIYnmswX156cpYn6wwAqsm9vDek1rnIqn930uruqIM%2FQbn5EQ%2B3EW%2BlnF15Ooy0GZNQbCXmdU1ntXcghqmioIissWg3vVG39BVwar8q8oNyvsHROv6t6PEGOXH3K1MngtioFAzU8bEHRV%2BQpL9Fry%2BHzwWq7Ya9H51Jcj5r0Mun7OwMhWpVHsOp8lRjrltwBnceZMXucxQBiar5C2mUyT3e9BhgOqyeM2DefPqwAmuwnWRl%2F8dW1kRnt%2FSoJX%2F4VJrP3y8hcuVeCpsU%2BDMLPeVJJRYZrRRcbSsxHXKbns02a7X6zcL29WaVDrl%2B36BQmBPN02JoOXj4QEDvw48E0pTtJ9jhcIKfU95yNsIhrct%2B6xaB%2Fum1Qa1SXH7MF9U8hfWXpMymBlylZ037CCK1JOQfZcqrkPci37GVtnP9fHuZYtprMtmVX8F9NX4sJv99t43poHK%2F6LdCLS1XjhoLiL6tu7SlR5V6b4ipaGnnXtpzBr%2BmlkZMI0bcoNDkpQoZCIGTm5kKiKYW3Rtf2aBgKng3hxg8sY0RXc5NONWoi%2FCXTsFvjpKlgQ5bjK1tQxTeAWWdgF4Qmav2T3B%2Fkqv%2FgP%2FmaiaxZtmL5Xaae76tVTkCCpzZ3movE9zHBvY22iAYc0FD0CYJHrfYf4Yle54LurdTrTPCPeIVTM8mXJpuku6IIFU%2B4p4qMa6lCvMUFqKgt%2FBMzQZIAg3RXVbqU%2FbGo24w8bdB2YdlE8JblrDyuhI6Cz6UALGGxHxSwIHeX4LJ%2FxhEUt0YtWCVmCMY2BVzO4jgcS5XUrkKzLAQmYLP8NyzgOSIbW0lF%2FQHqLVp9%2FXT7%2B%2BuVP6D28fH4JfpnfS2pFpZ6AgKx05W%2FwR1zFnQfwfITPeHi56USGiXqPJrkuy7WBWTRUfDliISugrIVU94DYMZjZdm1HsD26JlkNsnqwPdL5l9Wy1QsxcSIqc4LBT6cdWe8VXMLYjz7uWzlRrp3DdmnzOorbqaKlsTkLw%2BW66CpausclPwzOza4RLTTZefELJSNOVP2AHVM64FrbwdGbhtX8HPZp9BbZ59F5nlh69KGYkV71jlj%2BlOf6RPAjtD3gKI8m5CrebUUMqFtNA0Der34hKToJ%2FpvEkmxlIb85KjeQdFc44EBzc5IyEashZrjk%2F9GP%2FSVOMA35WUl%2B1tKC18Pys2B6e9ePORob3OYRJNySZWXdcUSThPSIIhiJ4RDdf7F%2BgTmiRjXJQhKSl5tN6ujY4Dvv9xnH0ZT8%2BfEpgRPc9BikK%2FT566evn%2Fn8Jv6Bg%2B4SBOD%2FN3ZvVB%2BnFfdJoNpLLY10yEC2mjDkL%2FthLzA6qqIe0pdy7sqy01i5NObzyBa15oweTR7SD4xquV3WVAsO%2BqNfgJlGN4A5Pax%2FyBHWYaNYr%2FFXmUqZWJ5eSaeAiebQ7N05snVkQlUHc1zVnGkC6t4cnHGjYXmZceO2z%2FYVzfHhJ0FE%2FbhYetNojrb45%2BDo1URbQEwzENCcGG%2FVqLJDwy0qhqfHW%2BNDAy45l8aGw3AJcAoIvr6mgZKEHBD3ll1VZNwfq3riFCt%2B4Gx8km3gUmo5ynWjiabZ1bWjsTYBhTE5dPGo1n5Us4GNrtnZs4GOfpz9GLtspM1vPe%2FJfHhAOty6UTWTKzIGYproujSMfV0ahrME59MwZ12WrlUFra6k1bfKULBeNwYOq0d48e%2BsRkBzP6qX60TvQK3VqYXF2RW%2FdeQyEL9zxzCtTiw7OHCwTOmAawMBnt5uptc19zT6FlPE1wofTG8yy1JqbJcu7ua9KttF5fNabNeYxQDgMnXqjJcuOhnnqKnSJobpjpi6Ks9zj3GN94kaw2PKqs6YpKFL7q1r89QKXMK0Wo434aqhxsBE0%2B549M%2Bxj6yOMU22XsPk17wUm1tDXF4gVfxTxOB5hg8Z4xA9LKrqxv3N9E626UXTyBFI4uFImmf1tenF5bDoSfbp2pIaH7eH8%2FjkKKpbxniB77K9HxyihlUGuUyetEtWBgBdGQB0CQA4Lg%2BrlMey19I7yrcq7oprSGRjV2EkPnz8kWfatWE1US0QKNMvJ%2Bcdzhr634jOuWSqwZXHdvXvuG7G7pndOzFIuaplMYqnq1kWAxyf1cWPhpj8vKpAvz%2FW9MSZs6WlTTEmIgeVP6GwJxIYNAREPR%2FRfHiVqemy256QbRULb8oEK3uchLKND2JQRLe65%2Be1fcvKys7KztDmklBcEXrMfd%2BDHcGu5GiAwUtrLJTvIxqTQs9r0IGnIW%2BIxhSyFwBxS5WUv6rCMVNW0nc7Ks%2FfQMbqQ2E6%2FZYS0vLsyG83i0VbvemeeLZ9wVM%2Bby1RnZXvY%2BjyAxXqzr%2BQI7XbAzMKsXyYr5uFnzUcpT5mBlZDPWjQnkVMFzOaUhED%2FFJnf0ImFhReZW1C13ImqjQuUpugG%2Bwqxz5lfXB1gtPWk%2BKI2pQdyKsyA1KtigPGiFn5c93yiIXzFMV1RlHP2ZcjDzEYA42tbRrzL0zoqTSCH2%2FjqHTjeOKxxbx4S00NgiUGwFeVmqAyeC2pCZ5HZ8tU0IWBCxupy9S7cVVPY2C7k2OX4Wnab98Xp3EUWxVLdOmJM194nAJLh5yTbrz6tnvYIvydY%2FS2CI8wQnf6lEknT%2FKyAFrlx7it%2FNae3txWS3RbyzfVtZ7CON8meEIQ8koiIa00hDpNlqmU45N2GMsgY6jaC291KLgdkkXHsteW7P%2BUsVdVrsiqewsTMS93Kz9etr5JjiUuj3kt0i3CHYOK6BdD9BTsNgwpy4VY4qp%2FzrTBN7lS3wR4Ou%2BbSIsEaZKLWZVQZmjEzEnX46Glr%2BsY1EyjmnE6g6ahiFAGEHWeiOxYnsET6Ym9Ek9Eyl5Vnkjtsfg512r8kEHG%2BwWBxJWQgkBZAaHkOPYZTjINJ7hd7QluQp7DsyQL4LoURaoqHCTHvmM%2F4Vv%2B0oxSh1RedMg5FMw36DY0KBjDyqvEOt%2B6CrPZ%2FR8d7vu2DtO0kdQb0WXq%2Faf97Rt8Xnz7T4nHRHWYEkLZcRYK6k4PXpC2PnmFtvkxB3vQZA%2Fs7sLdUKokk2TAH0rRnyR3OJ9qcPqO5S%2FwJK8ekDFYmddXl48%2B%2FYC7nCZ%2Fi8bgNqpWE1pHPWGpSkHZYh7z0uU4jXt6WispaGL2Emun3NFfY9M%2B9sg6r60nxeumtpiZxJXNQzRxtdGEbbC7lx1a29Na6tfH23HkIJInJjGQNpG%2Fo2Xyksp59o3oGHhBvG2nZHeTNFEXRi5Mn9A40B0l8QuE4j4UqZmr8q8OCf9Yg1cH4a6GsI8cqbz0W5m7PORIFbIXaBJ3%2BZyl%2FZK3HpHaeGxKsIrgfd3KFiBJQB9vcyVzM8fewgesNRoL3Yum%2FX3TMMUa8Cj%2FelA8vSITdNQ8NODqH5pi5vYcL%2BSaaJ4xYk6RNhW9861x1aL1gKILlkLyr9spz2s49SA5oSPF3rwj5oKuMsijDuNl6l5p%2BF66JMce9OiwHbnq3vAn57ZYeHaeA9RAcdxZ5XBhTfNGp52gZgFWSRUdnukUNVfUUY2Jn4soKe5UeI%2FvonuptjExSB0N%2FgPs4pSrOxPP0cqT2c6bj3DOmqaqYNrlDwXUNOMYSB8PQrokd9Uo1B18XGLlj8WO6aB522PHOQ6hSJNONHePUO4FmJ5pTcwzvwTTEfNk58Gl6VksLsFRZ1XWwrIVbfrlwGZb3MK5C5BuOnIrm6536U01jC515qljcjsfdfMUg703%2BeW7fm3XPqPF7qwsLwhf%2FnhlV3MnnrtXne5xQDaAyQPZztVu%2BdeXyUaXCYRZlTzxN6tHuMAbFj%2F%2BFw%3D%3D)
