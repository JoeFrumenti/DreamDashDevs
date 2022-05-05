using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScrolling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-10 * Time.deltaTime, 0, 0);

        if(transform.position.x < -27)
        {
            print(transform.position.x);
            transform.position = new Vector3(24f, transform.position.y, transform.position.z);
            print(transform.position.x);
        }
    }
}
