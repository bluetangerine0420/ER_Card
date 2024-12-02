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
        Debug.Log("BigTurnStart 실행");
        CreditManager.creditManager.GetCredit(BattleManager.battleManager.player1, turn_Start_Credit);
        CreditManager.creditManager.GetCredit(BattleManager.battleManager.player2, turn_Start_Credit);
        Debug.Log("GetCredit 실행");

        CardManager.cardManager.CardDraw(BattleManager.battleManager.player1);
        CardManager.cardManager.CardDraw(BattleManager.battleManager.player2);
        Debug.Log("CardDraw 실행");

        bool player1_first = BattleManager.battleManager.isPlayerFirst(BattleManager.battleManager.player1, BattleManager.battleManager.player2);
        Debug.Log("isPlayerFirst 실행");
        Debug.Log(player1_first);

        if (player1_first)
        {
            Debug.Log("player1_TurnAwake");
            TurnAwake(BattleManager.battleManager.player1, BattleManager.battleManager.player2);
        }

        else
        {
            Debug.Log("player2_TurnAwake");
            TurnAwake(BattleManager.battleManager.player2, BattleManager.battleManager.player1);
        }
    }
     
    public void PlayerBigTurnEnd(Player player)
    {
        player.bigTurn = false;
        SmallTurnEnd();
    }

    private void TurnAwake(Player FirstPlayer, Player SecondPlayer)
    {
        FirstPlayer.bigTurn = true;
        FirstPlayer.curTurn = true;

        SecondPlayer.bigTurn = true;
        SecondPlayer.curTurn = false;
    }

    public void SmallTurnStart()
    {
        
    }

    public void SmallTurnEnd()
    {
        Debug.Log("SmallTurnEnd");

        if (!BattleManager.battleManager.player1.bigTurn&&!BattleManager.battleManager.player2.bigTurn)
        {
            BigTurnEnd();
        }

        else if (BattleManager.battleManager.player1.curTurn)
        {
            Debug.Log("1 curTurn");
            if (BattleManager.battleManager.player2.bigTurn)
            {
                BattleManager.battleManager.player1.curTurn = false;
                BattleManager.battleManager.player2.curTurn = true;
                Debug.Log("player2 turn");
            }
        }
        else if (BattleManager.battleManager.player2.curTurn)
        {
            Debug.Log("2 curTurn");
            if (BattleManager.battleManager.player1.bigTurn)
            {
                BattleManager.battleManager.player1.curTurn = true;
                BattleManager.battleManager.player2.curTurn = false;
                Debug.Log("player1 turn");
            }
        }
    }
    public void BigTurnEnd()
    {
        Debug.Log("BigTurnEnd 실행");
        BigTurnStart();
    }
    
}

