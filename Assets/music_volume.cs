using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_volume : MonoBehaviour
{

    public GameObject cam;
    private AudioSource _audioSource;
    public void MusicVolume(float v)
    {
        _audioSource.volume = v;
    }

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = cam.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
