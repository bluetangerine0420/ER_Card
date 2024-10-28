using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientCard : Card
{
    public Equipment equipment;
    public Ingredient material;

    public void Awake()
    {
        image.sprite = material.sprite;
    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetMaterianl(material, equipment);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetMaterianl(material, equipment);
        }
        Debug.Log("재료카드 실행");
        gameObject.SetActive(false);


    }
}
