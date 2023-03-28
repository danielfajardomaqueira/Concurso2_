using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class music_manager : MonoBehaviour
{

    public AudioClip[] Songs;

    private int currentSong;

    public Button playButton, pauseButton;

    private AudioSource _audioSource;

    public TextMeshProUGUI songText;

    // Start is called before the first frame update
    void Start()
    {
        currentSong = 0;
        _audioSource.clip = Songs[currentSong];
        UpdateSongName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySong()
    {
        _audioSource.clip = Songs[currentSong];
        _audioSource.Play();
    }
    
    public void NextSong()
    {
        currentSong++;
        if (currentSong >= Songs.Length)
        {
            currentSong = 0;
        }
        PlaySong();
        UpdateSongName();
    }

    public void PreviousSong() {
        currentSong--;
        if (currentSong < 0)
        {
            currentSong = Songs.Length - 1;
        }
        PlaySong();
        UpdateSongName();
    }

    public void RandomSong()
    {
        currentSong = Random.Range(0,Songs.Length);
        PlaySong();
        UpdateSongName();
    }

    public void UpdateSongName() {
        songText.text = Songs[currentSong].name;
    }

    public void PlayButtonFunction()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }

    public void PauseButtonFunction()
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }

    /*
    public void PlayPauseButtonFunction(bool playButtonHasBeenPressed)
    {
        playButton.interactable = !playButtonHasBeenPressed; //false
        pauseButton.interactable = playButtonHasBeenPressed; //true
    }
    */

}
