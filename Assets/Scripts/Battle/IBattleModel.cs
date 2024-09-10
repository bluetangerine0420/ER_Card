using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IBattleModel
    {
        public void BattleStart(Party party1, Party party2);
        public void GetBuff(Buff buff, Unit effecter);
        public void LossBuff(Unit unit);

        public bool isPlayerFirst();

        public Unit GetUnit(int index);
        public Party GetParty();

    }
}
