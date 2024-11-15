using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool isFrozen = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Freeze()
    {
        isFrozen = true;
        rb.velocity = Vector2.zero;
    }

    public void Unfreeze()
    {
        isFrozen = false;
    }

    void Update()
    {
        if (isFrozen)
            return;
    }
}
