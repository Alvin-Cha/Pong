using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene_after_second : MonoBehaviour
{
    public float second;
    public Load_scene ls;
    public string scene_name;

    void Start()
    {
        Invoke("ChangeAfterSecond", second);
    }

    public void ChangeAfterSecond(){
        ls.Loadscene(scene_name);
    }
}
