using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControl : MonoBehaviour
{
   
    public int speed;
    public Rigidbody2D rigidbody2D;
    private float movement;
 
    // Start is called before the first frame update
    void Start()
    {
       
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name=="PongPlayer")
        {
            movement = Input.GetAxisRaw("PongPlayer");
        }
        else
        {
            movement = Input.GetAxisRaw("PongPlayer2");
        }

        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, movement * speed);
       
    }
  

   
}
