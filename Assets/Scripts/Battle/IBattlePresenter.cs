using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IBattlePresenter
    {
        public void GetBuff(int index);
        public void LossBuff(int index);
    }
}
