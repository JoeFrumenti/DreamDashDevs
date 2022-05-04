using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    
    public Text scoreText;
    public GameObject scorekeep;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
