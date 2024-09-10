using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IBattlePresenter
    {
        public BuffDisplayModel CreatBuffDisplay(Buff buff);
        public UnitDisplayModel CreatUnitDisplay(Unit unit);
        public void GetBuff(int unitIndex);
        public void LossBuff(int index);
    }
}
