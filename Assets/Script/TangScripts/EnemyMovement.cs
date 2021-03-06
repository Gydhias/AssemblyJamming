using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float moveSpeed = 1f;
    Rigidbody2D rigidBody;

    bool isFacingRight;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            rigidBody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            rigidBody.velocity = new Vector2(-moveSpeed, 0f);
        }
        
    }
    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rigidBody.velocity.x)), 1f);
    }
}
