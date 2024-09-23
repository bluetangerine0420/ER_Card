using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IBattlePresenter
    {
        public BuffDisplayModel CreatBuffDisplay(Buff buff);
        public UnitDisplayModel CreatUnitDisplay(Unit unit);

        public void UseSkill(Unit user, Unit effecter, int SkillIndex);
        
        public void UnitChange(Player party,int changeUnitIndex);

        public void SmallTurnEnd();
        public void BigTurnEnd();

        public void GetBuff(int unitIndex);
        public void LossBuff(int index);
    }

