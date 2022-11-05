using UnityEngine;
using TMPro;

public class CoinStarTrigger : MonoBehaviour
{
    public TMP_Text description;
    public int coinsCollected = 0;
    public int starsCollected = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            description.text = "Coins Collected: " + coinsCollected.ToString() + " Stars Collected: " + starsCollected.ToString() + " Level: Grass Plains";
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Star")
        {
            starsCollected++;
            description.text = "Coins Collected: " + coinsCollected.ToString() + " Stars Collected: " + starsCollected.ToString() + " Level: Grass Plains";
            other.gameObject.SetActive(false);
        }
    }
}
