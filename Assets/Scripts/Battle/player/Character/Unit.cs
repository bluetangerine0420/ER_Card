using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Unit : MonoBehaviour
{
    public string id;

    public float hp_Max;
    public float hp_Cur;

    public float st_Max;
    public float st_Cur;

    public int speed;

    public float atk;
    public float def;

    public Equipment[] equipments = new Equipment[3];

    public Skill[] skills;
    public Buff[] buffs;

    public void GetEquipment(Equipment equipment)
    {
        switch (equipment.part)
        {
            case EquipmentPart.weapon:
                equipments[0] = equipment;
                break;
            case EquipmentPart.chest:
                equipments[1] = equipment;
                break;
            case EquipmentPart.leg:
                equipments[2] = equipment;
                break;
        }
    }
}

