using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCard : Card
{
    public Equipment equipment;
    public Material material;

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
    }
}
