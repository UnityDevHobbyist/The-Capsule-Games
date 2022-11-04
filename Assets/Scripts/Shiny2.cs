using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Shiny2 : MonoBehaviour
{
    int shinyBalls = 5;
    int shinyBallsCollected = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI winText;

    void Start()
    {
        winText.enabled = false;
        countText.text = shinyBallsCollected.ToString() + " / " + shinyBalls.ToString();
    }

    void Update()
    {
        if (transform.position.y < -9 && shinyBalls == 0)
            SceneManager.LoadScene("SampleScene");
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "ShinyBall")
        {
            shinyBalls -= 1;
            shinyBallsCollected += 1;
            countText.text = shinyBallsCollected.ToString() + " / " + shinyBalls.ToString();
        }

        if (shinyBalls == 0)
        {
            print("! Victory !");
            winText.enabled = true;
        }
    }
}
