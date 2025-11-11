using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using App.lol.Utilities;

namespace App.lol
{
    internal class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
             new GradientColorKey(ColorLib.Purple, 0.5f),
            new GradientColorKey(ColorLib.Purple, 0.5f),
            new GradientColorKey(ColorLib.Purple, 0.5f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
