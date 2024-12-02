using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class DrinkCard : Card
{
    public Drink drink;
    public Hand hand;

    public void Awake()
    {
        image .sprite = drink.sprite;
        rectTransform = GetComponent<RectTransform>();

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
        gameObject.SetActive(false);
        hand.card_Num_Cur--;
    }
}
