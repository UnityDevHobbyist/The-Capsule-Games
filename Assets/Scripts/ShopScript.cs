using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
    public GameObject UI;
    public GameObject default_UI;
    public GameObject tutorial_UI;
    void Update()
    {
        if (Input.GetKey("e"))
        {
            OpenScene();
        }
        else if (Input.GetKey("t"))
        {
            tutorial_UI.SetActive(true);
            UI.SetActive(false);
            default_UI.SetActive(false);
        }
    }

    void OpenScene()
    {
        UI.SetActive(true);
        default_UI.SetActive(false);
    }
}
