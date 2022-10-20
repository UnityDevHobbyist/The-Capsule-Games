using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10)
            transform.position = new Vector3(0, 5.5f, 0);
    }
}
