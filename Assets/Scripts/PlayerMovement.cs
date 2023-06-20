using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    public float moveHorizontal;
    public float moveVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // moveHorizontal = Input.GetAxis("Horizontal");
        // moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical = 1f;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical = -1f;
        } else 
        {
            moveVertical = 0f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1f;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f;
        } else 
        {
            moveHorizontal = 0f;
        }
         
        if (moveVertical>0 && moveHorizontal==0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);//face up
        } else if (moveVertical<0 && moveHorizontal==0)
        {
            transform.rotation = Quaternion.Euler(0,0,180);//face down
        } else if (moveVertical==0 && moveHorizontal>0)
        {
            transform.rotation = Quaternion.Euler(0,0,-90);//face right
        } else if (moveVertical==0 && moveHorizontal<0)
        {
            transform.rotation = Quaternion.Euler(0,0,90);//face left
        }


        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.velocity = movement * speed;
    }
}
