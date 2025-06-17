using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed = 5f;

    void Start()
    {
        Vector2 initialDirection = new Vector2(
            Random.value >= 0.5f ? 1f : -1f,
            Random.Range(0.5f, 1f)
        ).normalized;

        rb.velocity = initialDirection * startingSpeed;

        rb.freezeRotation = true; // prevent rolling/spinning
    }
}
