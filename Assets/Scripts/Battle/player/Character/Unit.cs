﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Unit : MonoBehaviour
{
    public string id;

    public float max_Hp;
    public float cur_Hp;

    public float max_Stamina;
    public float cur_Stamina;

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

    public void GetFood(Food food)
    {
        if (!(cur_Hp + food.hp >= max_Hp))
        {
            cur_Hp += food.hp;
        }
        else
        {
            cur_Hp = max_Hp;
        }
    }

    public void GetDrink(Drink drink)
    {
        cur_Stamina += drink.stamina;
    }

    public void GetMaterianl(Material material, Equipment equipment)
    {///**/
        switch (material.materialKind)
        {
            case MaterialKind.LifeWood: equipment = equipment.lifeWood_Equipment; break;
            case MaterialKind.Meteorite: equipment = equipment.meteorite_Equipment; break;
            case MaterialKind.Mithril: equipment = equipment.mithril_Equipment; break;
            case MaterialKind.ForceCore: equipment = equipment.forceCore_Equipment; break;
            case MaterialKind.VfBloodSample: equipment = equipment.vfBloodSample_Equipment; break;
        }
    }
}

