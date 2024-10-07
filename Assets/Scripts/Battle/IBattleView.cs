using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


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
    public struct SkillDisplayModel
    {
        public Animation SkillAnimation { get; }

        public SkillDisplayModel(Animation skillAnimation)
        {
            SkillAnimation = skillAnimation;
        }
    }
    public interface IBattleView
    {

        public void FirstPlayer();
        public void BigTurnStart();

        public void GetCredit();
        public void LossCredit();

        public void ShowBuff(BuffDisplayModel getBuffs, int index);
        public void HideBuff(int index);
            
        public void UnitStateUpdate(UnitDisplayModel unit);

        public void FrontUnit(Image unit);
        public void BackUnit();
        public void ShowChangeUi();
        public void HideChangeUi();

        public void ShowSkillEffect(SkillDisplayModel skillEffect);

        public void BigTurnEnd();
        public void SmallTurnEnd();

        public void ShowUnitState();
        public void HideUnitState();

    }

