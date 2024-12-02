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

public abstract class Card : MonoBehaviour
{
    public string id;
    public int cost;
    public CardType type;
    public  Image image;
    public RectTransform rectTransform;

    

    public abstract void UseCard();
    public void MoveCard(Vector2 vec)
    {
        rectTransform.anchoredPosition = vec;
    }
}
