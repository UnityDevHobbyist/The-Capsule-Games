using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingSelling : MonoBehaviour
{
    static public int currentCoins = 0;
    static public int currentStars = 0;
    static public int currentCoinsGottenThisLevel = 0;
    static public int currentStarsGottenThisLevel = 0;
    static public int jumpBoostCost = 3;
    static public string jumpBoostCostType = "Coin";
    static public int speedBoostCost = 1;
    static public string speedBoostCostType = "Star";
    static public float playerSpeedMultiplier = 1;
    static public float playerJumpMultiplier = 1;
    static public float walk_speed;
    static public float sprint_speed;
    static public float jump_height;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Coin")
        {
            currentCoins++;
            currentCoinsGottenThisLevel++;
        }
        else if (collider.name == "Star")
        {
            currentStars++;
            currentStarsGottenThisLevel++;
        }
        if (collider.tag == "Danger")
        {
            currentCoins -= currentCoinsGottenThisLevel;
            currentStars -= currentStarsGottenThisLevel;
        }
    }

    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
