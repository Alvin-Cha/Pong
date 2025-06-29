using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement1 : MonoBehaviour
{
    public float move_speed;

    void Update() {
        bool is_pressing_w = Input.GetKey(KeyCode.W);
        bool is_pressing_s = Input.GetKey(KeyCode.S);

        if(transform.position.y >= 1.25f){
            transform.position = new Vector2(transform.position.x, 1.24f);
        } else if (is_pressing_w){
            transform.Translate(Vector2.right * Time.deltaTime * move_speed);
        }
        
        if(transform.position.y <= -1.25f){
            transform.position = new Vector2(transform.position.x, -1.24f);
        }else if(is_pressing_s){
            transform.Translate(Vector2.left * Time.deltaTime * move_speed);
        }
    }
}
