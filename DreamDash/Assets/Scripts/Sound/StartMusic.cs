using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Music S = GameObject.Find("SoundGuy").GetComponent<Music>();
        S.playMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
