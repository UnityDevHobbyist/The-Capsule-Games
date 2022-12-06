using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentStars : MonoBehaviour
{
    public TMP_Text coins;
    public TMP_Text stars;
    public TMP_Text coins2;
    public TMP_Text stars2;
    private void Update()
    {
        coins.text = "Current Coins: " + BuyingSelling.currentCoins;
        stars.text = "Current Stars: " + BuyingSelling.currentStars;
        coins2.text = "Coins: " + BuyingSelling.currentCoins;
        stars2.text = "Stars: " + BuyingSelling.currentStars;
    }
}
