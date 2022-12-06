using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JBCostScript : MonoBehaviour
{
    public TMP_Text COST;
    private void Update()
    {
        if (BuyingSelling.jumpBoostCost > 1)
        {
            COST.text = "Cost: " + BuyingSelling.jumpBoostCost.ToString() + " " + BuyingSelling.jumpBoostCostType + "s";
        }
        else
        {
            COST.text = "Cost: " + BuyingSelling.jumpBoostCost.ToString() + " " + BuyingSelling.jumpBoostCostType;
        }
    }
}
