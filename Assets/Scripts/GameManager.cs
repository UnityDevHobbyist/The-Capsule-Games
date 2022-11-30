using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public int coinsPickedUp;
    static public int starsPickedUp;
    static public int currentCoins;
    static public int currentStars;
    static public int lastSceneOpened;
    static public bool playerBoughtSpeed = false;
    static public bool playerBoughtJump = false;

    void Update()
    {
        lastSceneOpened = SceneManager.GetActiveScene().buildIndex;
    }
}
