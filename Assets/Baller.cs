using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;
    private Vector2 direction;

    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5f;
        float xVelocity = isRight ? 1f : -1f;
        float yVelocity = UnityEngine.Random.Range(-1f, 1f);

        direction = new Vector2(xVelocity, yVelocity).normalized;
        rb.velocity = direction * startingSpeed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            rb.AddForce(rb.velocity.normalized * 2f, ForceMode2D.Force);
        }
    }
}
