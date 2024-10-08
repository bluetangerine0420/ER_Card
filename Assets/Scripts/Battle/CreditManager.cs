using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditManager : MonoBehaviour
{
    public static CreditManager creditManager = null;

    void Awake()
    {
        if (null == creditManager)
        {
            creditManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GetCredit(Player player, int getCredit)
    {
        player.credit += getCredit;
    }

    public void LossCredit(Player player, int lossCredit)
    {
        if(player.credit - lossCredit > 0) 
            player.credit -= lossCredit;
        else player.credit = 0;
    }
}
