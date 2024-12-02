using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EquimentCard : Card 
{
    public Equipment equipment;
    public Hand hand;

    public void Awake()
    {
        image.sprite = equipment.sprite;
        rectTransform = GetComponent<RectTransform>();

    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetEquipment(equipment);
            Debug.Log("GetEquipment 1 실행");
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetEquipment(equipment);
            Debug.Log("GetEquipment 2 실행");

        }
        Debug.Log("장비카드 실행");
        gameObject.SetActive(false);
        hand.card_Num_Cur--;

    }

}
