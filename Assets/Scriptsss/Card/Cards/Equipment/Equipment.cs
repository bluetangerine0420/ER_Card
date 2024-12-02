using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Equipment", menuName = "Data/Equipment", order = int.MinValue)]
public class Equipment : ScriptableObject
{
    public EquipmentPart part;

    public Equipment meteorite_Equipment;
    public Equipment lifeWood_Equipment;
    public Equipment forceCore_Equipment;
    public Equipment mithril_Equipment;
    public Equipment vfBloodSample_Equipment;

    public Sprite sprite;

    public float Atk;
    public float Def;
    public string id;


}


public enum EquipmentPart
{
    weapon,
    chest,
    leg
}

