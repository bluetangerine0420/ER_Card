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
        Debug.Log("�����Ͱ� ī�� UI�� ���Խ��ϴ�.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("�����Ͱ� ī�� UI���� �������ϴ�.");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Item Using
        Debug.Log("ī�� UI�� Ŭ���Ǿ����ϴ�.");
    }
}
