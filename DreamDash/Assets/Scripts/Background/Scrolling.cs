using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-5 * Time.deltaTime, 0, 0);

        if(transform.position.x < -23.11f)
        {
            print(transform.position.x);
            transform.position = new Vector3(28f, transform.position.y, transform.position.z);
            print(transform.position.x);
        }
    }
}
