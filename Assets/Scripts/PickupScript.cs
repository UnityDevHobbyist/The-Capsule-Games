using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class PickupScript : MonoBehaviour
{
    public TMP_Text coins;
    public TMP_Text stars;
    public static List<GameObject> gameObjects = new List<GameObject>();
    public GameObject[] coins2;
    public bool destroy;
    
    //public GameManager gameManager;

    void Start()
    {
        if (destroy)
        {
            this.gameObject.SetActive(false);
        }
        GameManager.coinsPickedUp = 0;
        GameManager.starsPickedUp = 0;
        coins.text = "Coins: " + GameManager.currentCoins.ToString();
        stars.text = "Stars: " + GameManager.currentStars.ToString();
    }

    void OnTriggerEnter()
    {
        if (gameObject.tag == "Coin")
        {
            GameManager.coinsPickedUp++;
            GameManager.currentCoins++;
            coins.text = "Coins: " + GameManager.currentCoins;
        }
        else if (gameObject.tag == "Star")
        {
            GameManager.starsPickedUp++;
            GameManager.currentStars++;
            stars.text = "Stars: " + GameManager.currentStars;
        }
        Destroy(gameObject);
        gameObjects.Add(this.gameObject);
        destroy = true;
    }
}
