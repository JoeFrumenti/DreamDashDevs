using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float speedY;
    float playerSpeed = 7f;
    float input;
    float accel = 2f;
    int facing = 1;
    bool touchingWall = false;


    Rigidbody2D body;
    Animator anim;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        audioData = GetComponent<AudioSource>();

        //transform.position = new Vector3(Screen.width/16, transform.position.y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        //update facing variable
         if (body.velocity.y < 0)
        {
            facing = -1;
        }
        else if (body.velocity.y > 0)
        {
            facing = 1;
        }

        //update input
        updateVInput();
        //set speed to speed times input
        body.velocity = new Vector2(body.velocity.x, playerSpeed * input);
    }

    

    //movement code
    void updateVInput()
    {
        if (input >= -1 && input <= 1)
        {

            if (Input.GetAxisRaw("Vertical") != 0)
            {
                input += accel * Input.GetAxisRaw("Vertical") * Time.deltaTime;
            }

            if (Input.GetAxisRaw("Vertical") == 0)
            {
                input -= accel * facing * Time.deltaTime;
            }

            if (input < -1)
                input = -1;

            if (input > 1)
                input = 1;


        }
        else
        {
            if (input < -1)
                input = -1;
            if (input > 1)
                input = 1;

        }
        if(touchingWall)
            input = accel * Input.GetAxisRaw("Vertical") * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.layer == 7)
        {
            GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().isCounting = false;
            anim.Play("Explode");
        }
        if(collision.gameObject.layer == 9)
        {
            touchingWall = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            GameObject.FindWithTag("Scorekeep").GetComponent<Scorekeep>().isCounting = false;
            anim.Play("Explode");
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        touchingWall = false;
    }

    

    void die()
    {
        
        Destroy(this.gameObject);
        SceneManager.LoadScene("GameOver");
    }

    void playDeathNoise()
    {
        audioData.Play();
    }
}
