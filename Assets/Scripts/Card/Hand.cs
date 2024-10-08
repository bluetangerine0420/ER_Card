using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;


    public class Hand : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
        private int card_Num_Max;
        public int card_Num_Cur;

        public Card[] cards;
        
        private void Start()
        {
            card_Num_Max = cards.Length;
        }

        private void Update()
        {
            
        }
    public void OnPointerEnter(PointerEventData eventData)
    {
        // All Card Big
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // All Card Small
    }


}

