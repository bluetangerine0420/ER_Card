using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


    public class BattleModel : MonoBehaviour, IBattleModel
    {
        public Player playerParty;
        public Player enemyParty;
        public ICardModel m_cardModel;
        public void BattleStart(Player playerParty, Player enemyParty)
        {
            this.playerParty = playerParty;
            this.enemyParty = enemyParty;
        }

        public bool isPlayerFirst()
        {
            int playerSpeed, enemySpeed;
            playerSpeed = (playerParty.units[0].speed + playerParty.units[1].speed + playerParty.units[2].speed) / playerParty.units.Length;
            enemySpeed = (enemyParty.units[0].speed + enemyParty.units[1].speed + enemyParty.units[2].speed) / enemyParty.units.Length;

            if (playerSpeed > enemySpeed) return true;
            else if (playerSpeed < enemySpeed) return false;

            if (UnityEngine.Random.Range(0, 2) == 0) return true;
            else return false;

        }

        public void GetBuff(Buff buff, Unit effecter)
        {
            for (int i = 0; i < effecter.buffs.Length; i++)
            {
                if (effecter.buffs[i] != null || effecter.buffs[i].id == buff.id)
                {
                    if (buff.isStack) effecter.buffs[i].time += buff.time;
                    else effecter.buffs[i] = buff;
                    break;
                }

            }
        }
        public void LossBuff(Unit unit)
        {
            for (int i = 0; i < unit.buffs.Length; i++)
            {
                if (unit.buffs[i].time <= 0 && !unit.buffs[i].isStack)
                {
                    for (int j = 0; j < unit.buffs.Length; j++)
                    {
                        if (!(unit.buffs[i].time <= 0 && !unit.buffs[i].isStack) || unit.buffs[i].isStack)
                            unit.buffs[i] = unit.buffs[j];
                        unit.buffs[j] = null;
                    }
                }
            }
        }
        public void UseSkill(Unit user, Unit effecter, int SkillIndex)
        {
            user.skills[SkillIndex].UseSkill(effecter);
        }
        public bool UnitChange(Player party, int changeUnitIndex)
        {
            if (party.units[changeUnitIndex] == party.cur_Unit) return false;
            else party.cur_Unit = party.units[changeUnitIndex];
            return true;
        }

        

        public void SmallTurnEnd()
        {
            if (playerParty.curTurn)
            {
                if (enemyParty.bigTurn)
                {
                    playerParty.curTurn = false;
                    enemyParty.curTurn = true;
                }
            }
            else if (enemyParty.curTurn)
            {
                
            }
        }

        public void BigTurnStart()
        {
            m_cardModel.CardDraw();

        }

        public void BigTurnEnd()
        {

        }
        public Unit GetUnit(int index)
        {
            return playerParty.units[index];
        }

        public Player GetParty()
        {
            return playerParty;
        }


    }

