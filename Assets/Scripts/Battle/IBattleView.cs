using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public struct UnitDisplayModel
    {
        public Sprite UnitSprite { get; }
        public Image HpSprite { get; }

        public UnitDisplayModel(Sprite unitSprite, Image hp)
        {
            UnitSprite = unitSprite;
            HpSprite = hp;
        }
    }
    public struct BuffDisplayModel
    {
        public Sprite BuffSprite { get; }
        public string Id { get; }
        public int Time { get; }

        public BuffDisplayModel(Sprite buffSprite, string id ,int time)
        {
            BuffSprite = buffSprite;
            Id = id;
            Time = time;
        }
    }
    public interface IBattleView
    {
        public void ShowBuff(BuffDisplayModel getBuffs, int index);
        public void HideBuff(int index);

        public void FrontUnit(Image unit);
        public void BackUnit(Image unit);
        public void UnitUpdate(UnitDisplayModel unit);


        public void ShowUnitState();
        public void HideUnitState();
    }
}
