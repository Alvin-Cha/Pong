using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actual_ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    void Start(){
        bool is_right = UnityEngine.Random.value >= 0.5;

        float xVelocity = 5;

        if(is_right == true){
            xVelocity = 1f;
        }
    
        float yVelocity = UnityEngine.Random.Range(-1f, 1f);

        Vector2 direction = new Vector2(xVelocity, yVelocity).normalized;
        rb.velocity = direction * startingSpeed;
    }

    void FixedUpdate(){
        rb.velocity = rb.velocity.normalized * startingSpeed;
    }

    void reset_position(){
        
    }
}
