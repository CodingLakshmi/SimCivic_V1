using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class WallButton : MonoBehaviour
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

// void onButtonClicked()
//     {
        
//         wall.transform.Translate(0.3f, 0f, 0f);


//     }

public void ChangeScene()
    {
        SceneManager.LoadScene("GreenerCity");
    }

}
