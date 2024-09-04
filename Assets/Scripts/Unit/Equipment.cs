using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    public enum Part
    {
        weapon,
        head,
        chest,
        arm,
        leg
    }

    public class Equipment
    {
        public Part part;
        public float Atk;
        public float Def;
        public string id;
    }
}
