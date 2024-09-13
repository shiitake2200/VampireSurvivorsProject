using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementsScript : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float speed;
    float moveLimiter = 0.7f;
    void Start()
    {
        speed = GetComponent<PlayerScript>().MoveSpeed;
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
