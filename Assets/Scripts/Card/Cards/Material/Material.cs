using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MaterialKind
{
    Nomal,
    Meteorite,
    LifeWood,
    ForceCore,
    Mithril,
    VfBloodSample,
}

public class Material
{
    public string id;
    public MaterialKind materialKind;
}

