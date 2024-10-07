﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Unit :MonoBehaviour
{
    public string id;

    public float hp_Max;
    public float hp_Cur;

    public float st_Max;
    public float st_Cur;

    public int speed;

    public float atk;
    public float def;

    public Equipment[] equipments = new Equipment[5];

    public Skill[] skills;
    public Buff[] buffs;
}

