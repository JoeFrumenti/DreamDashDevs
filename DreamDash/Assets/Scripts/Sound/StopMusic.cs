using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Music S = GameObject.Find("SoundGuy").GetComponent<Music>();
        S.stopMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
