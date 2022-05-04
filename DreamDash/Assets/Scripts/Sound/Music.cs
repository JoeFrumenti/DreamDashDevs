using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        audioData = GetComponent<AudioSource>();
    }

    public void playMusic()
    {
        if(!audioData.isPlaying)
            audioData.Play();
    }

    public void stopMusic()
    {
        audioData.Stop();
    }
}
