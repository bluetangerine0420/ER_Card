using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EquimentCard : Card 
{
    public Equipment equipment;

    public void Awake()
    {
        image.sprite = equipment.sprite; 
    }

    public override void UseCard()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            BattleManager.battleManager.player1.cur_Unit.GetEquipment(equipment);
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetEquipment(equipment);
        }
        Debug.Log("장비카드 실행");
        gameObject.SetActive(false);

    }

}
