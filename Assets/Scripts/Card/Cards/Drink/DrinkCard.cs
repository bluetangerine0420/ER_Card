using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkCard : Card
{
    public Drink drink;

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
    }
}
