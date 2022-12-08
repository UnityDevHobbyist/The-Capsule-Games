using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ShopController : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    static int coinsCollected = 0;
    static int starsCollected = 0;

    int coinsCollectedThisLevel = 0;
    int starsCollectedThisLevel = 0;

    public GameObject DefaultUI;
    public GameObject ShopUI;
    public GameObject TutorialUI;

    static List<string> objectsPickedUp = new List<string>();
    public static bool restartedGame = false;

    public TMP_Text DefaultUICoins;
    public TMP_Text DefaultUIStars;
    public TMP_Text ShopUICoins;
    public TMP_Text ShopUIStars;
    public GameObject JumpPurchaseButton;
    public GameObject SpeedPurchaseButton;
    public TMP_Text LevelUI;
    public TMP_Text JumpCost;
    public TMP_Text SpeedCost;

    public static float JumpMultiplier = 1;
    public static float SpeedMultiplier = 1;

    List<int> JumpBoostCost = new List<int>()
    {
        3,
        5,
    };

    List<string> JumpBoostCostType = new List<string>()
    {
        "Coins",
        "Coins",
    };

    List<double> JumpBoostMultiplierList = new List<double>()
    {
        2,
        1.5,
    };

    static int JumpBoostIndex = 0;

    List<int> SpeedBoostCost = new List<int>()
    {
        1,
        3,
        5,
    };

    List<string> SpeedBoostCostType = new List<string>()
    {
        "Star",
        "Stars",
        "Coins",
    };

    List<double> SpeedBoostMultiplierList = new List<double>()
    {
        2,
        1.5,
        2,
    };

    static int SpeedBoostIndex = 0;

    List<string> levelNames = new List<string>()
    {
        "",
        "Cloudy Journey",
        "Rocky Cliffs",
        "Yummy Desert",
        "Snowy Mountain",
        "Grass Plains",
    };

    // Start is called before the first frame update
    void Start()
    {
        LevelUI.text = "Level: " + levelNames[SceneManager.GetActiveScene().buildIndex];

        DefaultUI.SetActive(true);
        ShopUI.SetActive(false);
        TutorialUI.SetActive(false);

        SetText();

        if (restartedGame)
        {
            print(objectsPickedUp.Count);
            restartedGame = false;
        }
    }

    void SetText()
    {
        DefaultUICoins.text = "Coins: " + coinsCollected;
        DefaultUIStars.text = "Stars: " + starsCollected;
        ShopUICoins.text = "Coins: " + coinsCollected;
        ShopUIStars.text = "Stars: " + starsCollected;

        JumpCost.text = "Cost: " + JumpBoostCost[JumpBoostIndex].ToString() + " " + JumpBoostCostType[JumpBoostIndex];
        SpeedCost.text = "Cost: " + SpeedBoostCost[SpeedBoostIndex].ToString() + " " + SpeedBoostCostType[SpeedBoostIndex];
    }

    // Update is called once per frame
    void Update()
    {
        CheckForKeysPressed();

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void PurchaseJump()
    {
        print("Attempting to purchase jump");
        if (JumpBoostIndex < JumpBoostCost.Count)
        {
            if (JumpBoostCostType[JumpBoostIndex] == "Coin" || JumpBoostCostType[JumpBoostIndex] == "Coins")
            {
                print(coinsCollected);
                if (coinsCollected >= JumpBoostCost[JumpBoostIndex])
                {
                    print("Purchased jump");
                    coinsCollected -= JumpBoostCost[JumpBoostIndex];
                    JumpMultiplier = (float)JumpBoostMultiplierList[JumpBoostIndex];
                    myTrigger.Invoke();
                    SetText();
                    JumpBoostIndex++;
                }
            }
            else
            {
                if (starsCollected >= JumpBoostCost[JumpBoostIndex])
                {
                    print("Purchased jump");
                    starsCollected -= JumpBoostCost[JumpBoostIndex];
                    JumpMultiplier = (float)JumpBoostMultiplierList[JumpBoostIndex];
                    myTrigger.Invoke();
                    SetText();
                    JumpBoostIndex++;
                }
            }
        }
    }

    public void PurchaseSpeed()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            coinsCollectedThisLevel++;
            other.gameObject.SetActive(false);
            objectsPickedUp.Add(other.gameObject.name);
            SetText();
        }
        else if (other.tag == "Star")
        {
            starsCollected++;
            starsCollectedThisLevel++;
            other.gameObject.SetActive(false);
            objectsPickedUp.Add(other.gameObject.name);
            SetText();
        }
        else if (other.tag == "Danger")
        {
            coinsCollected -= coinsCollectedThisLevel;
            starsCollected -= starsCollectedThisLevel;
            restartedGame = true;
        }
    }

    void CheckForKeysPressed()
    {
        if (Input.GetKey("e"))
        {
            DefaultUI.SetActive(false);
            ShopUI.SetActive(true);
            TutorialUI.SetActive(false);
        }
        else if (Input.GetKey("t"))
        {
            DefaultUI.SetActive(false);
            ShopUI.SetActive(false);
            TutorialUI.SetActive(true);
        }
        else if (Input.GetKey("escape"))
        {
            DefaultUI.SetActive(true);
            ShopUI.SetActive(false);
            TutorialUI.SetActive(false);
        }
    }
}
