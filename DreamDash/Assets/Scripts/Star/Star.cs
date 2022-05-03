using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    internal float moveSpeed = 10f;
    internal Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
