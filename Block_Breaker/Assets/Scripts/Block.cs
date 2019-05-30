using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Rigidbody2D ball;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        ball.velocity = new Vector2(ball.velocity.x, -ball.velocity.y);
    }
}