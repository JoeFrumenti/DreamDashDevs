using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speedY;
    float playerSpeed = 5f;
    float input;
    float accel = 3f;
    int facing = 1;


    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
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
    }

    
}
