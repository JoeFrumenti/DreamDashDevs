using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeep : MonoBehaviour
{
    public int score = 0;
    float scoreTimer = 0;
    public bool isCounting = false;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(isCounting)
        {
            scoreTimer+=Time.deltaTime;
            if(scoreTimer >= 1)
            {
                score ++;
                scoreTimer --;
            }
        }
    }
    public void resetScore()
    {
        score = 0;
        scoreTimer = 0;
    }
}
