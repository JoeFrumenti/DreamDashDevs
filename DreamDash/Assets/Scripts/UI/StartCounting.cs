using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCounting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().isCounting = true;
        GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().resetScore();
    }

    // Update is called once per frame
    
}
