using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public float moveSpeed = 10f;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-moveSpeed,0,0);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }
}
