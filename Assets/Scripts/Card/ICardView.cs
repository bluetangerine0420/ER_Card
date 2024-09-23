using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

    public struct CardDisplayModel
    {
        public Sprite UnitSprite { get; }
        public Image HpSprite { get; }

        public CardDisplayModel(Sprite unitSprite, Image hp)
        {
            UnitSprite = unitSprite;
            HpSprite = hp;
        }
    }
    public interface ICardView
    {
        public void CardDraw(CardDisplayModel card);
        public void CardUse();
    }

