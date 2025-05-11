using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private int damageLimit=0;
    public int value = 150;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            damageLimit++;

            if (damageLimit == 2)
            {
                ScoreManager.Instance.addPoints(value);
                Destroy(gameObject);
            }

        }
    }
}
