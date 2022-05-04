using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    float diffX;
    float diffY;

    float playerX;
    float playerY;

    float hitBoxSize = 1f;

    float angle;
    float abovePlayer = -1f;

    float speed = 3f;

    Animator anim;
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    //calculate how much to change in x and y direction
        //get player location
        playerX = GameObject.Find("Player").transform.position.x;
        playerY = GameObject.Find("Player").transform.position.y;

        diffX = playerX - transform.position.x;
        diffY = playerY - transform.position.y;

        angle = (float)Math.Atan(diffY/diffX);

        //do some cool vector linear algebra trigonometry stuff
        diffX = (float)(Math.Cos(angle) * speed);
        diffY = (float)(Math.Sin(angle) * speed);

        
        // if(transform.position.y > playerY)
        //     abovePlayer = 1;
        // else 
        //     abovePlayer = -1;

        //move in x and y direction
        transform.Translate(-diffX * Time.deltaTime, diffY *Time.deltaTime * abovePlayer, 0);

         if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            if(mousePos.x > transform.position.x - hitBoxSize &&
                mousePos.x < transform.position.x + hitBoxSize &&
                mousePos.y > transform.position.y - hitBoxSize &&
                mousePos.y < transform.position.y + hitBoxSize)
                    anim.Play("Explode");
        }
    }

    void die()
    {
        Destroy(this.gameObject);
    }

    void playDeathNoise()
    {
        audioData.Play();
    }
}
