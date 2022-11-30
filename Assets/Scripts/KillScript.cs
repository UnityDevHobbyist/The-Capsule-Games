using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.currentCoins -= GameManager.coinsPickedUp;
            GameManager.currentStars -= GameManager.starsPickedUp;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
