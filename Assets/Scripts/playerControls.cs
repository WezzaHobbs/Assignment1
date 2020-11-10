using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        int speed = 20;
        int ySpeed;
        int xSpeed;
        if(Input.GetKey("w"))
        {
            ySpeed = speed;
        }
        else if (Input.GetKey("s"))
        {
            ySpeed = -speed;
        }
        else
        {
            ySpeed = 0;
        }
        if (Input.GetKey("d"))
        {
            xSpeed = speed;
        }
        else if (Input.GetKey("a"))
        {
            xSpeed = -speed;
        }
        else
        {
            xSpeed = 0;
        }
        if ((ySpeed != 0) && (xSpeed != 0))
        {
            ySpeed = Sqrt(2) / ySpeed;
            xSpeed = Sqrt(2) / xSpeed;
        }

        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
}
