using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockUnitSkill2 : Skill
{
    public override void UseSkill()
    {
        unit.TargetElseAttack(3);
        Debug.Log("SKill 2 사용됨");
        TurnManager.turnManager.SmallTurnEnd();
    }

}
