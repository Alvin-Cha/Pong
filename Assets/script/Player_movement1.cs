using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement1 : MonoBehaviour
{
    public float jump_force = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump_force);
        }
    }
}
