using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Data/Food", order = int.MinValue)]

public class Food : ScriptableObject 
{
    public int hp;
    public string id;
}

