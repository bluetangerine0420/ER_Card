using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodCard : Card
{
    public Food food;
    public Hand hand;

    public void Awake()
    {
        image.sprite = food.sprite;
        rectTransform = GetComponent<RectTransform>();

    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetFood(food);
            CreditManager.creditManager.LossCredit(BattleManager.battleManager.player1,cost);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetFood(food);
            CreditManager.creditManager.LossCredit(BattleManager.battleManager.player2, cost);
        }
        
        Debug.Log("음식카드 실행");
        gameObject.SetActive(false);
        hand.card_Num_Cur--;

    }
}
