using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -4)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lava Block")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
