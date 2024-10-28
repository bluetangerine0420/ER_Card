using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodCard : Card
{
    public Food food;

    public void Awake()
    {
        image.sprite = food.sprite;
    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetFood(food);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetFood(food);
        }
        Debug.Log("음식카드 실행");
        gameObject.SetActive(false);

    }
}
