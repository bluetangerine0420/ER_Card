using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public abstract class Skill
{
    public Unit unit;
    public string id { get; }
    public abstract void UseSkill();
}

