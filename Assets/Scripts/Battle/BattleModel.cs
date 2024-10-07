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

    public Unit GetUnit(int index)
    {
        return playerParty.units[index];
    }

    public Player GetParty()
    {
        return playerParty;
    }


}

