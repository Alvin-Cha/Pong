using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement2 : MonoBehaviour
{
    public float jump_force = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Enter key
        {
            rb.velocity = new Vector2(rb.velocity.x, jump_force);
        }
    }
}
