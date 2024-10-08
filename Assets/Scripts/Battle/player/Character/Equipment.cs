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
        public float Atk;
        public float Def;
        public string id;
    }

