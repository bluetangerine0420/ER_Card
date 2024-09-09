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
        public int Time { get; }

        public BuffDisplayModel(Sprite buffSprite, int time)
        {
            BuffSprite = buffSprite;
            Time = time;
        }
    }
    public interface IBattleView
    {
        public void ShowBuff(BuffDisplayModel getBuffs, int index);
        public void HideBuff(int index);

        public void FrontUnit(Image unit, Vector2 FrontVec);
        public void BackUnit(Image unit, Vector2 BackVec);
        public void UnitUpdate(UnitDisplayModel unit);


        public void ShowUnitState();
        public void HideUnitState();
    }
}
