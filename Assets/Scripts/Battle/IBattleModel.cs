using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IBattleModel
    {
        public void BattleStart(Player party1, Player party2);
        public bool isPlayerFirst();

        public void GetCredit();
        public void LossCredit();

        public void GetBuff(Buff buff, Unit effecter);
        public void LossBuff(Unit unit);


        public void UseSkill(Unit user, Unit effecter, int SkillIndex);
        public bool UnitChange(Player party, int changeUnitIndex);

        public void BigTurnStart();
        public void SmallTurnEnd();
        public void BigTurnEnd();

        public Unit GetUnit(int index);
        public Player GetParty();

    }

