using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;


    public class Hand : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
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
        Debug.Log("포인터가 핸드 UI에 들어왔습니다.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("포인터가 핸드 UI에서 나갔습니다.");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Item Using
        Debug.Log("핸드 UI가 클릭되었습니다.");
    }
}

