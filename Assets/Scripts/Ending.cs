using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public Transform ball;
    private Vector2 startPos;
    private void Start()
    {
        Vector2 startPos = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ball.transform.position = startPos;
        }
    }
}
