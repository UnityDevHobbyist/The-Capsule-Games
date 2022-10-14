using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    int x = 0;
    int z = 0;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * x * Time.deltaTime * 10;
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            x = -1;
        }
        else
        {
            x = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            z = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            z = 1;
        }
        else
        {
            z = 0;
        }
    }
}
