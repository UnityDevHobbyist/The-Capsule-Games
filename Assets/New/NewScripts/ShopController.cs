using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("ShopUI").SetActive(false);
        GameObject.Find("TutorialUI").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
