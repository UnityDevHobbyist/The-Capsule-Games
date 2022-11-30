using UnityEngine;
using TMPro;

public class PickupScript : MonoBehaviour
{
    public TMP_Text coins;
    public TMP_Text stars;
    //public GameManager gameManager;

    void Start()
    {
        GameManager.coinsPickedUp = 0;
        GameManager.starsPickedUp = 0;
        coins.text = "Coins: " + GameManager.currentCoins.ToString();
        stars.text = "Stars: " + GameManager.currentStars.ToString();
    }

    void OnTriggerEnter()
    {
        if (gameObject.name == "Coin")
        {
            GameManager.coinsPickedUp++;
            GameManager.currentCoins++;
            coins.text = "Coins: " + GameManager.currentCoins;
        }
        else
        {
            GameManager.starsPickedUp++;
            GameManager.currentStars++;
            stars.text = "Stars: " + GameManager.currentStars;
        }
        Destroy(gameObject);
    }
}
