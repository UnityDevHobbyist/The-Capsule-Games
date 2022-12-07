using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    void OnTriggerEnter()
    {
        if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 1)
        {
            ShopFinalVersion.LevelCompleted = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

