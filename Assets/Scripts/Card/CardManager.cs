using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class CardManager : MonoBehaviour
{
    public static CardManager cardManager = null;
    void Awake()
    {
        if (null == cardManager)
        {
            cardManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }



    public void CardDraw(Player player)
    {
        player.hand.cards[player.hand.card_Num_Cur] = player.deck.cards[0];
        player.deck.cards[0] = null;
        player.deck.DeckSort();
    }
}

