using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 10;
        transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        cam.transform.position = transform.position + new Vector3(0, 50, 0);
        cam.transform.LookAt(transform);
    }
}
