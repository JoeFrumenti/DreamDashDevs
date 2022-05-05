using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScrolling : MonoBehaviour
{

    [SerializeField]
    float leftbound = -30f;
    float rightbound = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-10 * Time.deltaTime, 0, 0);

        if(transform.position.x < -25f)
        {
            print(transform.position.x);
            transform.position = new Vector3(27f, transform.position.y, transform.position.z);
            print(transform.position.x);
        }
    }
}
