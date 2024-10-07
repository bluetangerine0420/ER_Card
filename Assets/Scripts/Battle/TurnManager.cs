using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class TurnManager : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;
    [SerializeField] BuffManager buffManager;
    [SerializeField] CreditManager creditManager;
    [SerializeField] CardManager cardManager;

    public int cur_Turn;
    public int turn_Start_Credit;

    public void BigTurnStart()
    {
        creditManager.GetCredit(battleManager.player1,turn_Start_Credit);
        creditManager.GetCredit(battleManager.player2,turn_Start_Credit);
        
        cardManager.CardDraw(battleManager.player1);
        cardManager.CardDraw(battleManager.player2);

        bool player1_first = battleManager.isPlayerFirst(battleManager.player1, battleManager.player2);
        if(player1_first) SmallTurnStart(battleManager.player1);
        else SmallTurnStart(battleManager.player2);
    }
    public void SmallTurnStart(Player player)
    {

    }
    public void SmallTurnEnd()
    {
        if (battleManager.player1.curTurn)
        {
            if (battleManager.player2.bigTurn)
            {
                battleManager.player1.curTurn = false;
                battleManager.player2.curTurn = true;
            }
        }
        else if (battleManager.player2.curTurn)
        {
            if (battleManager.player1.bigTurn)
            {
                battleManager.player1.curTurn = true;
                battleManager.player2.curTurn = false;
            }
        }
    }
    public void BigTurnEnd()
    {
       for(int i = 0; i < 3; i++) 
        {
            buffManager.LossBuff(battleManager.player1.units[i]);
            buffManager.LossBuff(battleManager.player2.units[i]);
        }
    }
    
}

