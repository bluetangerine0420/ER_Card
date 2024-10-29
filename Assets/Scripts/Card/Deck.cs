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
        int nullIndex = -1;
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == null)
            {
                nullIndex = i;
                break;
            }

        }

        if (nullIndex >= 0)
        {
            for (int i = nullIndex; i < card_Num_Cur - 1; i++)
            {
                if (cards[i + 1] != null)
                    cards[i] = cards[i + 1];
                card_Num_Cur = i;
            }
        }
        else
            return;
    }
    public void DeckMix()
    {
        Card[] rand_Card = cards;
        int[] rand = new int[rand_Card.Length];
    }
}

