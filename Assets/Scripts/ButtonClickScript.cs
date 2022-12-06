using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickScript : MonoBehaviour
{
    public void CheckIfUserHasEnoughForJumpBoost()
    {
        if (BuyingSelling.jumpBoostCostType == "Coin")
        {
            if (BuyingSelling.currentCoins >= BuyingSelling.jumpBoostCost)
            {
                BuyingSelling.currentCoins -= BuyingSelling.jumpBoostCost;
                BuyingSelling.currentCoinsGottenThisLevel -= BuyingSelling.jumpBoostCost;
                BuyingSelling.playerJumpMultiplier += 1;
                BuyingSelling.jump_height *= BuyingSelling.playerJumpMultiplier;
            }
        }

        if (BuyingSelling.jumpBoostCostType == "Star")
        {
            if (BuyingSelling.currentStars >= BuyingSelling.jumpBoostCost)
            {
                BuyingSelling.currentStars -= BuyingSelling.jumpBoostCost;
                BuyingSelling.currentStarsGottenThisLevel -= BuyingSelling.jumpBoostCost;
                BuyingSelling.playerJumpMultiplier += 1;
                BuyingSelling.jump_height *= BuyingSelling.playerJumpMultiplier;
            }
        }
    }

    public void CheckIfUserHasEnoughForSpeedBoost()
    {
        if (BuyingSelling.speedBoostCostType == "Coin")
        {
            if (BuyingSelling.currentCoins >= BuyingSelling.speedBoostCost)
            {
                BuyingSelling.currentCoins -= BuyingSelling.speedBoostCost;
                BuyingSelling.currentCoinsGottenThisLevel -= BuyingSelling.speedBoostCost;
                BuyingSelling.playerSpeedMultiplier += 1;
                BuyingSelling.walk_speed *= BuyingSelling.playerSpeedMultiplier;
                BuyingSelling.sprint_speed *= BuyingSelling.playerSpeedMultiplier;
            }
        }

        if (BuyingSelling.speedBoostCostType == "Star")
        {
            if (BuyingSelling.currentStars >= BuyingSelling.speedBoostCost)
            {
                BuyingSelling.currentStars -= BuyingSelling.speedBoostCost;
                BuyingSelling.currentStarsGottenThisLevel -= BuyingSelling.speedBoostCost;
                BuyingSelling.playerSpeedMultiplier += 1;
                BuyingSelling.walk_speed *= BuyingSelling.playerSpeedMultiplier;
                BuyingSelling.sprint_speed *= BuyingSelling.playerSpeedMultiplier;
            }
        }
    }
}
