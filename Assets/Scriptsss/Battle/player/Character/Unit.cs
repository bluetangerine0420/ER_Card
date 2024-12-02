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

    public Player myPlayer;
    public Player enemyPlayer;

    public void TargetAttack(int value)
    {
        enemyPlayer.cur_Unit.cur_Hp -= value - enemyPlayer.cur_Unit.def + atk;
    }

    public void AllAttack(int value)
    {
        for(int i = 0; i < 3; i++)
                enemyPlayer.units[i].cur_Hp -= value - enemyPlayer.cur_Unit.def + atk;
    }

    public void TargetElseAttack(int value)
    {
        for (int i = 0; i < 3; i++)
        {
            if (enemyPlayer.units[i] != enemyPlayer.cur_Unit)
                enemyPlayer.units[i].cur_Hp -= value - enemyPlayer.cur_Unit.def + atk;
        }
    }


    public void GetEquipment(Equipment equipment)
    {
        Debug.Log("장착");

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

    public void GetMaterianl(Ingredient material, Equipment equipment)
    {
        for (int i = 0; i < 3; i++)
        {
            if (equipment == equipments[i]) {
                switch (material.ingerdientKind)
                {
                    case IngredientKind.LifeWood: equipments[i] = equipment.lifeWood_Equipment; break;
                    case IngredientKind.Meteorite: equipments[i] = equipment.meteorite_Equipment; break;
                    case IngredientKind.Mithril: equipments[i] = equipment.mithril_Equipment; break;
                    case IngredientKind.ForceCore: equipments[i] = equipment.forceCore_Equipment; break;
                    case IngredientKind.VfBloodSample: equipments[i] = equipment.vfBloodSample_Equipment; break;
                }
            }
        }
    } 
}

