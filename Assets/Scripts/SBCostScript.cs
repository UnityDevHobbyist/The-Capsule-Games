using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SBCostScript : MonoBehaviour
{
    public TMP_Text COST;
    private void Update()
    {
        if (BuyingSelling.speedBoostCost > 1)
        {
            COST.text = "Cost: " + BuyingSelling.speedBoostCost.ToString() + " " + BuyingSelling.speedBoostCostType + "s";
        }
        else
        {
            COST.text = "Cost: " + BuyingSelling.speedBoostCost.ToString() + " " + BuyingSelling.speedBoostCostType;
        }
    }
}
