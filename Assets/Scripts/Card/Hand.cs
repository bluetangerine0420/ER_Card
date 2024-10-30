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
        gameObject.SetActive(false);
    }


}

