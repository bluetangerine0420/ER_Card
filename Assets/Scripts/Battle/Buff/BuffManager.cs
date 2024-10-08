using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class BuffManager : MonoBehaviour
{
    public static BuffManager buffManager = null;

    void Awake()
    {
        if (null == buffManager)
        {
            buffManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
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
}

