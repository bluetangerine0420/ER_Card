using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockUnitSkill1 : Skill
{
    public int m_value;

    public override void UseSkill()
    {
        unit.TargetAttack(m_value);
        Debug.Log("SKill 1 »ç¿ëµÊ");
       TurnManager.turnManager.SmallTurnEnd();
    }

}
