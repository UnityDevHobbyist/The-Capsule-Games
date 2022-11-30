using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("e"))
        {
            OpenScene();
        }
    }

    void OpenScene()
    {
        SceneManager.LoadScene(7);
    }
}
