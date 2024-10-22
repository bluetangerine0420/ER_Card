using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Ingredient", menuName = "Data/Ingredient", order = int.MinValue)]
public class Ingredient : ScriptableObject
{
    public string id;
    public IngredientKind materialKind;
    public Sprite sprite;
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

