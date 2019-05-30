using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTwoHits : MonoBehaviour
{
    public Rigidbody2D ball;
    public Sprite Block;
    public Sprite BlockBroken1;
    private SpriteRenderer cc;

    public int hitsNeeded = 2;
    public int hitsTaken;


    void Start()
    {
        hitsTaken = 0;
        cc = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        if (hitsTaken == 1)
        {
            cc.sprite = BlockBroken1;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitsTaken += 1;
        ball.velocity = new Vector2(ball.velocity.x, -ball.velocity.y);

        if (hitsTaken >= hitsNeeded)
        {
            Destroy(gameObject);
        }
    }
}
