using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DrinkCard : Card
{
    public Drink drink;

    public void Awake()
    {
        image = drink.sprite;
    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetDrink(drink);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetDrink(drink);
        }
        Debug.Log("음료카드 실행");

    }
}
