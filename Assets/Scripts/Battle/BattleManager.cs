using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class BattleManager : MonoBehaviour
{

    public Player player1;
    public Player player2;
    public TurnManager turnManager;

    public void Awake()
    {
        
    }

    public void Start()
    {
        //BattleStart(player1 , player2);
    }

    public void BattleStart(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
        turnManager.BigTurnStart();
    }

    public bool isPlayerFirst(Player player1, Player player2)
    {
        int player1Speed, player2Speed;
        player1Speed = (player1.units[0].speed + player1.units[1].speed + player1.units[2].speed) / player1.units.Length;
        player2Speed = (player2.units[0].speed + player2.units[1].speed + player2.units[2].speed) / player2.units.Length;

        if (player1Speed > player2Speed) return true;
        else if (player1Speed < player2Speed) return false;

        if (UnityEngine.Random.Range(0, 2) == 0) return true;
        else return false;

    }

    public bool UnitChange(Player party, int changeUnitIndex)
    {
        if (party.units[changeUnitIndex] == party.cur_Unit)
            return false;

        else party.cur_Unit = party.units[changeUnitIndex];
        return true;
    }
    public IEnumerator Battle()
    {
        if(player2.curTurn&&player2.bigTurn)
        {
            //player2 play
        }

        yield break;
    }

}

