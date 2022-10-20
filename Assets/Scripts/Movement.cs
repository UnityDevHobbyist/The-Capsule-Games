using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int x = 0;
    int z = 0;
    int speed = 5;
    bool isGrounded = false;

    void Update()
    {
        if (Input.GetKey("w"))
            x = 1;
        else if (Input.GetKey("s"))
            x = -1;
        else
            x = 0;
        if (Input.GetKey("a"))
            z = -1;
        else if (Input.GetKey("d"))
            z = 1;
        else
            z = 0;

        if (Input.GetKey("space") && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, 1) * x * Time.deltaTime * speed;
        transform.position += new Vector3(1, 0, 0) * z * Time.deltaTime * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" && !isGrounded)
            isGrounded = true;
    }
}
