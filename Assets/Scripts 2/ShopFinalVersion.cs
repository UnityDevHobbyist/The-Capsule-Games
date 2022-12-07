using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopFinalVersion : MonoBehaviour
{
    int coinsCollected = 0;
    int starsCollected = 0;
    int[] valueNeededForJump = { 3, 5 };
    string[] jumpPurchaseType = { "Coins", "Coins" };
    int[] valueNeededForSpeed= { 1, 3, 5 };
    int jumpArrayLength = 2;
    int speedArrayLength = 3;
    string[] speedPurchaseType = { "Star", "Stars", "Coins" };
    int index = 0;
    List<string> objectsCurrentlyDestroyed = new List<string>();
    static List<string> objectsToDestroy = new List<string>();
    static public bool LevelCompleted = false;

    public TMP_Text coinsUI;
    public TMP_Text starsUI;
    public TMP_Text coinsUI2;
    public TMP_Text starsUI2;

    private void Start()
    {
        if (LevelCompleted)
        {
            objectsCurrentlyDestroyed.Clear();
            objectsToDestroy.Clear();
            LevelCompleted = false;
        }
        if (objectsToDestroy.Count > 0)
        {
            for (int i = 0; i < objectsToDestroy.Count; i++)
            {
                GameObject.Find(objectsToDestroy[i]).SetActive(false);
            }
        }
    }

    private void Update()
    {
        print(coinsCollected);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            // Adds objects currently destroyed into a list
            objectsCurrentlyDestroyed.Add(other.name);
        }
    }

    public void PressedJumpPurchaseButton()
    {
        if (index < jumpArrayLength)
        {
            if (jumpPurchaseType[index] == "Coin" || jumpPurchaseType[index] == "Coins")
            {
                if (coinsCollected >= valueNeededForJump[index])
                {
                    Purchase("Jump", coinsCollected);
                }
            }
            else
            {
                if (starsCollected >= valueNeededForJump[index])
                {
                    Purchase("Jump", starsCollected);
                }
            }
        }
        else
        {
            print("Max upgrades bought");
        }
    }

    public void PressedSpeedPurchaseButton()
    {
        if (index < speedArrayLength)
        {
            if (speedPurchaseType[index] == "Coin" || speedPurchaseType[index] == "Coins")
            {
                if (coinsCollected >= valueNeededForSpeed[index])
                {
                    Purchase("Speed", coinsCollected);
                }
            }
            else
            {
                if (starsCollected >= valueNeededForSpeed[index])
                {
                    Purchase("Speed", starsCollected);
                }
            }
        }
        else
        {
            print("Max upgrades bought");
        }
    }

    void Purchase(string purchaseType, int currencyType)
    {
        if (purchaseType == "Jump")
        {
            print("Player bought jump");
            //Goes through all the objects that are currently destroyed and saves them into another list so that when the player dies all those
            //objects are destroyed
            for (int i = 0; i < objectsCurrentlyDestroyed.Count; i++)
            {
                objectsToDestroy.Add(objectsCurrentlyDestroyed[i]);
            }
            currencyType -= valueNeededForJump[index];
            index++;
        }
        else if (purchaseType == "Speed")
        {
            print("Player bought speed");
            //Goes through all the objects that are currently destroyed and saves them into another list so that when the player dies all those
            //objects are destroyed
            for (int i = 0; i < objectsCurrentlyDestroyed.Count; i++)
            {
                objectsToDestroy.Add(objectsCurrentlyDestroyed[i]);
            }
            currencyType -= valueNeededForJump[index];
            index++;
        }
    }
}
