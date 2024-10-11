using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public enum EquipmentPart
{
    weapon,
    chest,
    leg
}

public class Equipment : MonoBehaviour
{
    public EquipmentPart part;
    public Equipment meteorite_Equipment;
    public Equipment lifeWood_Equipment;
    public Equipment forceCore_Equipment;
    public Equipment mithril_Equipment;
    public Equipment vfBloodSample_Equipment;
    public float Atk;
    public float Def;
    public string id;
}

