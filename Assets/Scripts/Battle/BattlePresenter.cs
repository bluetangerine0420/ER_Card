using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class BattlePresenter : IBattlePresenter
    {
        IBattleModel m_battleModel;
        IBattleView m_battleView;

        public BuffDisplayModel CreatBuffDisplay(Buff buff)
        {

        }
        public UnitDisplayModel CreatUnitDisplay(Unit unit)
        {

        }
        public void GetBuff(int unitIndex)
        {
            //m_battleModel.GetBuff(b);
        }
        public void LossBuff(int index)
        {

        }
    }
}
