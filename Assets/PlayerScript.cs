using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 5.0f;
        Vector3 v = rb.velocity;
        Vector3 v2 = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        else
        {
            v.x = 0;
        }
        rb.velocity = v;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v2.x -= moveSpeed;
        }
        else
        {
            v2.x = 0;
        }
        rb.velocity = v2;
      
    }
}
