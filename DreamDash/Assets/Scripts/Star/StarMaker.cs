using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMaker : MonoBehaviour
{
    //Timers
    float starTimer = 0.5f;


    //Timer caps
    float starTimerReset;
    float difficultyTimer;
    
    //Difficulty caps
    float maxStarSpeed = 10f;
    float spawnSpeedLimit = 3f;
    float difficultyTimerLimit = 10f;

    //difficulty incremental values
    float starSpeedIncrement = 1f;


    float starSpeed = 5f;
    float currentSpeed;
    

    //Prefabs
    public GameObject starPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        starTimer += Time.deltaTime;
        difficultyTimer += Time.deltaTime;

        if(starTimer >= spawnSpeedLimit)
        {
            starTimer -= spawnSpeedLimit;
            currentSpeed = starSpeed;
            spawnStar(currentSpeed);
            spawnStar(currentSpeed);
            spawnStar(currentSpeed);
        }

        if(difficultyTimer >= difficultyTimerLimit)
        {
            difficultyTimer -= difficultyTimerLimit;
            if(starSpeed <= maxStarSpeed)
            {
                starSpeed += starSpeedIncrement;
            }

        }
    }

    void spawnStar(float newSpeed)
    {
        Instantiate(starPrefab, new Vector3(15, Random.Range(-6f, 6f), 0), Quaternion.identity);
        starPrefab.GetComponent<Star>().moveSpeed = newSpeed;
        
    }
}
