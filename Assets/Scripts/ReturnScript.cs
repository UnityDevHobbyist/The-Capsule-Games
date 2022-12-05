using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{
    bool boughtJump = false;
    bool boughtSpeed = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(GameManager.lastSceneOpened);
        }
        if (Input.GetKey(KeyCode.A) && GameManager.currentCoins >= 3 && !boughtJump)
        {

            boughtJump = true;
            GameManager.playerBoughtJump = true;
            GameManager.currentCoins -= 3;
        }
        if (Input.GetKey(KeyCode.B) && GameManager.currentStars >= 1 && !boughtSpeed)
        {
            boughtSpeed = true;
            GameManager.playerBoughtSpeed = true;
            GameManager.currentStars -= 1;
        }
    }
}
