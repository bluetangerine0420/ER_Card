using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class TurnManager : MonoBehaviour
{
    public static TurnManager turnManager = null;

    void Awake()
    {
        if (null == turnManager)
        {
            turnManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public int cur_Turn;
    public int turn_Start_Credit;

    public void BigTurnStart()
    {
        CreditManager.creditManager.GetCredit(BattleManager.battleManager.player1,turn_Start_Credit);
        CreditManager.creditManager.GetCredit(BattleManager.battleManager.player2,turn_Start_Credit);

        CardManager.cardManager.CardDraw(BattleManager.battleManager.player1);
        CardManager.cardManager.CardDraw(BattleManager.battleManager.player2);

        bool player1_first = BattleManager.battleManager.isPlayerFirst(BattleManager.battleManager.player1, BattleManager.battleManager.player2);
        if(player1_first) SmallTurnStart(BattleManager.battleManager.player1);
        else SmallTurnStart(BattleManager.battleManager.player2);
    }
    public void SmallTurnStart(Player player)
    {

    }

    public void SmallTurnEnd()
    {
        if (BattleManager.battleManager.player1.curTurn)
        {
            if (BattleManager.battleManager.player2.bigTurn)
            {
                BattleManager.battleManager.player1.curTurn = false;
                BattleManager.battleManager.player2.curTurn = true;
            }
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            if (BattleManager.battleManager.player1.bigTurn)
            {
                BattleManager.battleManager.player1.curTurn = true;
                BattleManager.battleManager.player2.curTurn = false;
            }
        }
    }
    public void BigTurnEnd()
    {
       for(int i = 0; i < 3; i++) 
        {
            BuffManager.buffManager.LossBuff(BattleManager.battleManager.player1.units[i]);
            BuffManager.buffManager.LossBuff(BattleManager.battleManager.player2.units[i]);
        }
    }
    
}

