using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinyBallScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
