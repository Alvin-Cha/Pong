using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement1 : MonoBehaviour
{
    public float move_speed;

    void Update() {
        bool is_pressing_w = Input.GetKey(KeyCode.W);
        bool is_pressing_s = Input.GetKey(KeyCode.S);

        if(is_pressing_w){
            transform.Translate(Vector2.up * Time.deltaTime * move_speed);
        }
        
        if(is_pressing_s){
            transform.Translate(Vector2.down * Time.deltaTime * move_speed);
        }
    }
}
