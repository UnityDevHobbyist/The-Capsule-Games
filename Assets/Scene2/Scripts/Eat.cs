using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Cube")
        {
            transform.localScale += new Vector3(.05f, .05f, .05f);
            obj.gameObject.SetActive(false);
        }
        else if (obj.tag == "Sphere")
        {
            transform.localScale += new Vector3(.1f, .1f, .1f);
            obj.gameObject.SetActive(false);
        }
    }
}
