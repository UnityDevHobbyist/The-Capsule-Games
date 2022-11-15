using UnityEngine;
using UnityEngine.SceneManagement;

public class YRotatorScript : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        gameObject.transform.Rotate(0, speed, 0);
    }
}
