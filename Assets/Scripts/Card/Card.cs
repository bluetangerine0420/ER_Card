using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum CardType
{
    food,
    drink,
    material    ,
    equipment
}

public abstract class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public string id;
    public int cost;
    public CardType type;

    public abstract void UseCard();
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Card Big
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Card Small
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        UseCard();
        gameObject.SetActive(false);
    }
}
