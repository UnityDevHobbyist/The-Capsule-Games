using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class Shop : MonoBehaviour
{
    StarterAssets.ThirdPersonController thirdPersonController;
    static int currentCoins = 0;
    static int currentStars = 0;
    GameObject[] coinsInScene;
    GameObject[] starsInScene;
    int coins;
    int stars;
    List<float> playerControls = new List<float>();
    public GameObject Shop_UI;
    public GameObject Tutorial_UI;
    public GameObject Default_UI;
    static public int[] jumpBoostCost = { 3 , 5 };
    static string[] jumpBoostCostType = { "Coins" , "Coins" };
    static int[] speedBoostCost = { 1 };
    static string[] speedBoostCostType = { "Star" };
    [SerializeField] private UnityEvent myTrigger;
    static int currentJumpIndex = 0;
    static int currentSpeedIndex = 0;
    int default_coins;
    int default_stars;
    static int coins_collected = 0;
    static int stars_collected = 0;
    public TMP_Text COIN_DEFAULT_UI;
    public TMP_Text STAR_DEFAULT_UI;
    public TMP_Text COIN_SHOP_UI;
    public TMP_Text STAR_SHOP_UI;
    public TMP_Text JUMP_COST;
    public TMP_Text SPEED_COST;
    public float player_speed;
    public float player_jump;
    static public float speed_multiplier = 1;
    static public float jump_multiplier = 1;
    float amountJumpBought = 0;
    float amountSpeedBought = 0;
    static int index = 0;
    GameObject[] objectsToDestroyThisRound;

    void Start()
    {
        for (int i = 0; i < namesOfDestroyedObjects.Count; i++)
        {
        }

        playerControls.Add(2f);
        playerControls.Add(5.335f);
        playerControls.Add(1.2f);
        coinsInScene = GameObject.FindGameObjectsWithTag("Coin");
        starsInScene = GameObject.FindGameObjectsWithTag("Star");
        coins = coinsInScene.Length;
        stars = coinsInScene.Length;
        default_coins = coinsInScene.Length;
        default_stars = coinsInScene.Length;
        myTrigger.Invoke();
        player_speed = playerControls[0];
        player_jump = playerControls[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            Shop_UI.SetActive(true);
            Tutorial_UI.SetActive(false);
            Default_UI.SetActive(false);
        }
        else if (Input.GetKey("t"))
        {
            Shop_UI.SetActive(false);
            Tutorial_UI.SetActive(true);
            Default_UI.SetActive(false);
        }
        else if (Input.GetKey("escape"))
        {
            Shop_UI.SetActive(false);
            Tutorial_UI.SetActive(false);
            Default_UI.SetActive(true);
        }
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        COIN_DEFAULT_UI.text = "Coins: " + currentCoins.ToString();
        COIN_SHOP_UI.text = "Current Coins: " + currentCoins.ToString();
        STAR_DEFAULT_UI.text = "Stars: " + currentStars.ToString();
        STAR_SHOP_UI.text = "Current Stars: " + currentStars.ToString();
        //print(currentJumpIndex);
        //print(jumpBoostCost.Length);
        if (currentJumpIndex < jumpBoostCost.Length)
        {
            JUMP_COST.text = "Cost: " + jumpBoostCost[currentJumpIndex].ToString() + " " + jumpBoostCostType[currentJumpIndex];
        }
        else
        {
            print("??");
            JUMP_COST.text = "Max";
        }
        if (currentSpeedIndex < speedBoostCost.Length)
        {
            SPEED_COST.text = "Cost: " + speedBoostCost[currentSpeedIndex].ToString() + " " + speedBoostCostType[currentSpeedIndex];
        }
        else
        {
            SPEED_COST.text = "Max";
        }
    }

    public static List<string> namesOfDestroyedObjects = new List<string>();

    private void Awake()
    {
        for (int i = 0; i < namesOfDestroyedObjects.Count; i++)
        {
            GameObject.Find(namesOfDestroyedObjects[i]).SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            currentCoins++;
            coins--;
            coins_collected++;
            COIN_DEFAULT_UI.text = "Coins: " + currentCoins.ToString();
            COIN_SHOP_UI.text = "Current Coins: " + currentCoins.ToString();
            namesOfDestroyedObjects.Add(other.gameObject.name);
            print(namesOfDestroyedObjects[0]);
            //objectsToDestroyThisRound[index] = other.gameObject;
            ///index++;
        }
        else if (other.tag == "Star")
        {
            currentStars++;
            stars--;
            stars_collected++;
            STAR_DEFAULT_UI.text = "Stars: " + currentStars.ToString();
            STAR_SHOP_UI.text = "Current Stars: " + currentStars.ToString();
            namesOfDestroyedObjects.Add(other.gameObject.name);
            //objectsToDestroyThisRound[index] = other.gameObject;
            //index++;
        }
        else if (other.name == "Danger")
        {
            //speed_multiplier -= amountSpeedBought;
            //jump_multiplier -= amountJumpBought;
            ///currentJumpIndex -= System.Convert.ToInt32(amountJumpBought);
            //currentSpeedIndex -= System.Convert.ToInt32(amountSpeedBought);
            //currentCoins -= coins_collected;
            //currentStars -= stars_collected;
        }
    }

    public void BuyingJump()
    {
        if (currentJumpIndex < jumpBoostCost.Length)
        {
            if (jumpBoostCostType[currentJumpIndex] == "Coin" || jumpBoostCostType[currentJumpIndex] == "Coins")
            {
                if (currentCoins >= jumpBoostCost[currentJumpIndex])
                {
                    currentCoins -= jumpBoostCost[currentJumpIndex];
                    currentJumpIndex++;
                    //print(currentJumpIndex);
                    player_jump *= jump_multiplier;
                    jump_multiplier += 1;
                }
            }
            else
            {
                if (currentStars >= jumpBoostCost[currentJumpIndex])
                {
                    currentStars -= jumpBoostCost[currentJumpIndex];
                    currentJumpIndex++;
                    player_jump *= jump_multiplier;
                    jump_multiplier += 1;
                }
            }
            COIN_DEFAULT_UI.text = "Coins: " + currentCoins.ToString();
            COIN_SHOP_UI.text = "Current Coins: " + currentCoins.ToString();
            STAR_DEFAULT_UI.text = "Stars: " + currentStars.ToString();
            STAR_SHOP_UI.text = "Current Stars: " + currentStars.ToString();
        }
    }

    public void BuyingSpeed()
    {
        print(currentSpeedIndex);
        print(speedBoostCost.Length);
        if (currentSpeedIndex < speedBoostCost.Length)
        {
            if (speedBoostCostType[currentSpeedIndex] == "Coin" || speedBoostCostType[currentSpeedIndex] == "Coins")
            {
                if (currentCoins >= speedBoostCost[currentSpeedIndex])
                {
                    currentCoins -= speedBoostCost[currentSpeedIndex];
                    currentSpeedIndex++;
                    player_speed *= speed_multiplier;
                    speed_multiplier += 1;
                }
            }
            else
            {
                if (currentStars >= speedBoostCost[currentSpeedIndex])
                {
                    currentStars -= speedBoostCost[currentSpeedIndex];
                    currentSpeedIndex++;
                    player_speed *= speed_multiplier;
                    speed_multiplier += 1;
                }
            }
            COIN_DEFAULT_UI.text = "Coins: " + currentCoins.ToString();
            COIN_SHOP_UI.text = "Current Coins: " + currentCoins.ToString();
            STAR_DEFAULT_UI.text = "Stars: " + currentStars.ToString();
            STAR_SHOP_UI.text = "Current Stars: " + currentStars.ToString();
        }
    }
}