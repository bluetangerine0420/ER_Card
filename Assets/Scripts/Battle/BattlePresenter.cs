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

        public void GetBuff(int index)
        {
            m_battleModel.GetBuff();
        }
        public void LossBuff(int index)
        {

        }
    }
}
