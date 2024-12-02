using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Card[] cards;
    public int card_Num_Max;
    public int card_Num_Cur;

    public void DeckSort()
    {
        for (int i = 0; i <= card_Num_Cur; i++)
        {
            if (i == card_Num_Cur)
            {
                cards[i] = null;
                break;
            }
            cards[i] = cards[i + 1];
        }
    }

    public void DeckMix()
    {
        Card[] rand_Card = cards;
        int[] rand = new int[rand_Card.Length];
    }
}

