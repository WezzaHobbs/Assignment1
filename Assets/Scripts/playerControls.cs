using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
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
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            ySpeed = speed;
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            ySpeed = -speed;
        }
        else
        {
            ySpeed = 0;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            xSpeed = speed;
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            xSpeed = -speed;
        }
        else
        {
            xSpeed = 0;
        }
        if ((ySpeed > 0) && (xSpeed > 0))
        {
            ySpeed = 14;
            xSpeed = 14;
        }
        else if ((ySpeed < 0) && (xSpeed < 0))
        {
            ySpeed = -14;
            xSpeed = -14;
        }
        else if ((ySpeed > 0) && (xSpeed < 0))
        {
            ySpeed = 14;
            xSpeed = -14;
        }
        else if ((ySpeed < 0) && (xSpeed > 0))
        {
            ySpeed = -14;
            xSpeed = 14;
        }

        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Respawn");
            transform.position = new Vector3(-9.416f, -3.82f, 0);
        }
        if (collision.gameObject.tag == "Wall")
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (collision.gameObject.tag == "Finish")
        {
            transform.position = new Vector3(1.4f, 8.27f, 0);
        }
    }
}
