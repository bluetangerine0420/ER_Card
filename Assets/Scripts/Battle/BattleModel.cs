using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class BattleModel : MonoBehaviour, IBattleModel
    {
        public Party playerParty;
        public Party enemyParty;

        public void BattleStart(Party playerParty, Party enemyParty)
        {
            this.playerParty = playerParty;
            this.enemyParty = enemyParty;
        }


        public void GetBuff(Unit unit)
        {

        }
        public void LossBuff(Unit unit)
        {

        }
        public void BuffCheck(Buff[] buffs)
        {

        }

        public bool isPlayerFirst(Party playerParty, Party enemyParty)
        {
            int playerSpeed, enemySpeed;
            playerSpeed = (playerParty.units[0].speed + playerParty.units[1].speed + playerParty.units[2].speed) / playerParty.units.Length;
            enemySpeed = (enemyParty.units[0].speed + enemyParty.units[1].speed + enemyParty.units[2].speed) / enemyParty.units.Length;

            if (playerSpeed > enemySpeed) return true;
            else if (playerSpeed < enemySpeed) return false;

            if (UnityEngine.Random.Range(0, 2) == 0) return true;
            else return false;

        }

        


    }
}
