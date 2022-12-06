using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("t"))
        {
            OpenScene();
        }
    }

    void OpenScene()
    {
        //SceneManager.LoadScene(8);
    }
}
