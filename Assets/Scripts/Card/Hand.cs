using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hand : MonoBehaviour
    {
        private int card_Num_Max;
        public int card_Num_Cur;

        public Card[] cards;
        public Deck deck;
        private void Start()
        {
            card_Num_Max = cards.Length;
        }

        private void Update()
        {
            
        }

        public void Draw()
        {

        }
    }
}
