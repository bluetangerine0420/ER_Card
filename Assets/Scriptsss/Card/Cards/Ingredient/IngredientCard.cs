using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientCard : Card
{
    public Equipment equipment;
    public Ingredient ingredient;
    public Hand hand;

    public void Awake()
    {
        image.sprite = ingredient.sprite;
        rectTransform = GetComponent<RectTransform>();

    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetMaterianl(ingredient, equipment);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetMaterianl(ingredient, equipment);
        }
        Debug.Log("재료카드 실행");
        gameObject.SetActive(false);
        hand.card_Num_Cur--;

    }
}
