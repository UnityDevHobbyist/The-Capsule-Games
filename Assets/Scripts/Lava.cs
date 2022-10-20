using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            transform.position = new Vector3(0, 5.5f, 0);
        }
    }
}
