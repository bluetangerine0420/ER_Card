using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum CardType
{
    consume,
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
        Debug.Log("포인터가 카드 UI에 들어왔습니다.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("포인터가 카드 UI에서 나갔습니다.");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Item Using
        Debug.Log("카드 UI가 클릭되었습니다.");
    }
}
