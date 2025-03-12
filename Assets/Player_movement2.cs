using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement2 : MonoBehaviour
{
    public float move_speed;

    void Update() {
        bool is_pressing_w = Input.GetKey(KeyCode.UpArrow);
        bool is_pressing_s = Input.GetKey(KeyCode.DownArrow);

        if(is_pressing_w){
            transform.Translate(Vector2.right * Time.deltaTime * move_speed);
        }
        
        if(is_pressing_s){
            transform.Translate(Vector2.left * Time.deltaTime * move_speed);
        }
    }
}
