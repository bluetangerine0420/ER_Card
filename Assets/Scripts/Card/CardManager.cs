using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class CardManager : MonoBehaviour
{
   

    public void CardDraw(Player player)
    {
        player.hand.cards[player.hand.card_Num_Cur] = player.deck.cards[0];
        player.deck.cards[0] = null;
        player.deck.DeckSort();
    }
}

