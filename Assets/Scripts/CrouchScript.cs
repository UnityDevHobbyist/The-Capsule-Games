using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    CapsuleCollider playerCol;
    float originalHeight;
    public float reducedHeight;

    // Start is called before the first frame update
    void Start()
    {
        playerCol = GetComponent<CapsuleCollider>();
        originalHeight = playerCol.height;
    }

    // Update is called once per frame
    void Update()
    {
        //Crouch;
        if (Input.GetKeyDown(KeyCode.C))
            Crouch();
        else if (Input.GetKeyUp(KeyCode.C))
            GoUp();
    }

    // Method to reduce height;

    void Crouch()
    {
        playerCol.height = reducedHeight;
        transform.localScale = new Vector3(1f, .5f, 1f);
    }

    // Method to reset height;

    void GoUp()
    {
        playerCol.height = originalHeight;
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
