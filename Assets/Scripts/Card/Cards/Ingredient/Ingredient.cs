using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


[CreateAssetMenu(fileName = "Ingredient", menuName = "Data/Ingredient", order = int.MinValue)]
public class Ingredient : ScriptableObject
{
    public string id;
   public IngredientKind materialKind;
}


public enum IngredientKind
{
    Nomal,
    Meteorite,
    LifeWood,
    ForceCore,
    Mithril,
    VfBloodSample,
}

