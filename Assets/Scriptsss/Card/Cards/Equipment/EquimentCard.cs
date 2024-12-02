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
            Debug.Log("GetEquipment 1 ����");
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            BattleManager.battleManager.player2.cur_Unit.GetEquipment(equipment);
            Debug.Log("GetEquipment 2 ����");

        }
        Debug.Log("���ī�� ����");
        gameObject.SetActive(false);
        hand.card_Num_Cur--;

    }

}
