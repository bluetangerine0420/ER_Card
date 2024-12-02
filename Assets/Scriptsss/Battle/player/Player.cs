using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Hand hand;
    public Deck deck;

    public Unit[] units;
    public Unit cur_Unit;

    public int credit;

    public bool bigTurn;
    public bool curTurn;

    public bool move;
    private void Start()
    {

    }
}
