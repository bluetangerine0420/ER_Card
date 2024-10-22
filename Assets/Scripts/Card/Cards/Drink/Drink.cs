using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Drink", menuName = "Data/Drink", order = int.MinValue)]

public class Drink : ScriptableObject
{
    public int stamina;
    public string id;
    public Sprite sprite;
}

