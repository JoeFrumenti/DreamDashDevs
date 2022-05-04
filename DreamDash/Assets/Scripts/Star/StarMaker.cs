using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMaker : MonoBehaviour
{
    //Timers
    float starTimer = 0.5f;
    float difficultyTimer;


    //Timer caps
    float starTimerReset;
    float difficultyTimerLimit = 5f;
    float spawnSpeedLimit = 1f;
    
    //Difficulty caps
    float maxStarSpeed = 15f;
    float minSpawnSpeed = 1f;

    //difficulty incremental values
    float starSpeedIncrement = 1f;


    float starSpeed = 5f;
    float currentSpeed;
    

    //Prefabs
    public GameObject starPrefab;
    public GameObject ghostPrefab;


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
            // spawnStar(currentSpeed);
            // spawnStar(currentSpeed);
            // spawnStar(currentSpeed);
            spawnGhost();
        }

        if(difficultyTimer >= difficultyTimerLimit)
        {
            difficultyTimer -= difficultyTimerLimit;
            if(starSpeed <= maxStarSpeed)
            {
                starSpeed += starSpeedIncrement;
            }

            if(spawnSpeedLimit > minSpawnSpeed)
            {
                spawnSpeedLimit -= 0.2f;
            }

        }
    }

    void spawnStar(float newSpeed)
    {
        //Instantiate(starPrefab, new Vector3(15, Random.Range(-5f, 5f), 0), Quaternion.identity);
        GameObject obj = (GameObject)Instantiate(starPrefab, new Vector3(15, Random.Range(-5f, 5f), 0), Quaternion.identity);
         obj.GetComponent<Rigidbody2D>().velocity = new Vector3(-starSpeed, 0, 0);
     
    }

    void spawnGhost()
    {
        GameObject obj = (GameObject)Instantiate(ghostPrefab, new Vector3(15, Random.Range(-5f, 5f), 0), Quaternion.identity);
    }
}
