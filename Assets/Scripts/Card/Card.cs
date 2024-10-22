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
    material    ,
    equipment
}

public abstract class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public string id;
    public int cost;
    public CardType type;
    public Image image;
    public string cardName;
    public TextMeshProUGUI nameText;
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
