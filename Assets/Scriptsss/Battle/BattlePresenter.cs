using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class BattlePresenter : IBattlePresenter
{
    IBattleModel m_battleModel;
    IBattleView m_battleView;

    public BuffDisplayModel CreatBuffDisplay(Buff buff)
    {
        //return new BuffDisplayModel(, buff.id, buff.time);
        return new BuffDisplayModel();
    }
    public UnitDisplayModel CreatUnitDisplay(Unit unit)
    {
       // return new UnitDisplayModel(,);
        return new UnitDisplayModel();
    }
    public SkillDisplayModel CreatSkillDisplay(Animation skillEffect)
    {
        return new SkillDisplayModel();
    }

    public void UseSkill(Unit user, Unit effecter, int SkillIndex)
    {
        //m_battleModel.UseSkill(user, effecter, SkillIndex);
        //m_battleView.ShowSkillEffect(CreatSkillDisplay(/*skillEfect*/));
    }
    public void UnitChange(Player party, int changeUnitIndex)
    {
        //if (m_battleModel.UnitChange(party, changeUnitIndex))
        //{
        //    m_battleView.BackUnit();
        //    m_battleView.FrontUnit(party.units[changeUnitIndex]);

        //}
        //else
        {
            m_battleView.HideChangeUi();
        }
    }
    public void SmallTurnEnd()
    {
        m_battleView.SmallTurnEnd();
    }
    public void BigTurnEnd()
    {
        m_battleView.BigTurnEnd();

    }
    public void GetBuff(int unitIndex)
    {
        //m_battleModel.GetBuff(b);
    }
    public void LossBuff(int index)
    {

    }
}

