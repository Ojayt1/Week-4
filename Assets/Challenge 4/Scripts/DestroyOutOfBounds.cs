using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float frontBound = 31;
    private float backBound = -11;
    private float leftBound = -21;
    private float rightBound = 21;
    private float ceilingBound = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > frontBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < backBound)
        {
            Destroy(gameObject);
        }
       
        
       if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }


        if (transform.position.y > ceilingBound)
        {
            Destroy(gameObject);
        }
    }
}
