using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public GameObject scorekeep;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().score.ToString();
    }
}
