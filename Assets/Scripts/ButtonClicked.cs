using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{

    GameObject wall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

public void ChangeScene()
    {
        wall.transform.Translate(0.3f, 0f, 0f);
    }

}
