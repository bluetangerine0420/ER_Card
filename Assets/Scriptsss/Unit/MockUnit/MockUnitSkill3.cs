using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockUnitSkill3 : Skill
{
    public override void UseSkill()
    {
        unit.AllAttack(3);
        Debug.Log("SKill 3 사용됨");
        TurnManager.turnManager.SmallTurnEnd();
    }

}
