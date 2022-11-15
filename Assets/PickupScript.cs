using UnityEngine;
using TMPro;

public class PickupScript : MonoBehaviour
{
    public TMP_Text coins;
    public TMP_Text stars;
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        if (gameObject.name == "Coin")
        {
            gameManager.coinsPickedUp++;
            coins.text = "Coins: " + gameManager.coinsPickedUp;
        }
        else
        {
            gameManager.starsPickedUp++;
            stars.text = "Stars: " + gameManager.starsPickedUp;
        }
        Destroy(gameObject);
    }
}
