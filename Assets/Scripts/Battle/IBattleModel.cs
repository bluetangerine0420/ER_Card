using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IBattleModel
    {
        public void BattleStart(Party playerParty, Party enemyParty);
        public void GetBuff(Unit unit);
        public void LossBuff(Unit unit);
        public void BuffCheck(Buff[] buffs);

        public bool isPlayerFirst(Party playerParty, Party enemyParty);



    }
}
