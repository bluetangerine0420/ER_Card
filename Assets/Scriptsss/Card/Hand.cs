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
    [SerializeField] Vector2 back_hand_Pos;
    [SerializeField] Vector2 front_hand_Pos;
    public Card[] cards;

    public Vector2[] cards_Pos;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        card_Num_Max = cards.Length;
        //for(int i = 0; i < cards_Pos.Length; i++)
        //    cards_Pos[i].y = rectTransform.anchoredPosition.y;
    }

    private void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = front_hand_Pos;
        //for (int i = 0; i < card_Num_Cur; i++)
        //    cards[i].rectTransform.anchoredPosition -= front_hand_Pos;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = back_hand_Pos;
        //for (int i = 0; i < card_Num_Cur; i++)
        //    cards[i].rectTransform.anchoredPosition += front_hand_Pos;
    }


}

