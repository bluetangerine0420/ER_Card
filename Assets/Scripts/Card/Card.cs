using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    consume,
    equipment

}

public abstract class Card
{
    public string id;
    public int cost;
    public CardType type;

    public abstract void UseCard();
}
