using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum CardType
{
    food,
    drink,
    ingredient,
    equipment
}

public abstract class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string id;
    public int cost;
    public CardType type;
    public  Image image;


    public abstract void UseCard();

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(id);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("³ª°¨");
    }


    
}
