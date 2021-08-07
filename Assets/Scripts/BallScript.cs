using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody2D = GetComponent<Rigidbody2D>();
        int randomNumber = Random.Range(0, 3);
        if (randomNumber <= 1)
        {
            rigidbody2D.AddForce(new Vector2(80, 10));

        }
        else
        {
            rigidbody2D.AddForce(new Vector2(-80, -10));

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag=="Player")
        {
            rigidbody2D.velocity = collision.collider.attachedRigidbody.velocity/2 + rigidbody2D.velocity;
           
        }
        
    }
}
