using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SkillCommand : ICommand
{
    private readonly Skill m_skill;

    public void Execute()
    {
        m_skill.UseSkill();
    }
}

