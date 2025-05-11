using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 8f;
    private float force = 15f;
    private int pointValue = 5;

     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
     }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            ScoreManager.Instance.addPoints(pointValue);

        }
        if (collision.gameObject.CompareTag("Paddle"))
        {

            Vector2 dir = new Vector2(Random.Range(-1f, 1f), 1).normalized;
            rb.velocity = dir * force;

        }
        else if (collision.gameObject.CompareTag("Brick") || collision.gameObject.CompareTag("Wall"))
        {

            Vector2 dir = new Vector2(Random.Range(-1f, 1f), -1).normalized;
            rb.velocity = dir * force;
        }
    }
}



   