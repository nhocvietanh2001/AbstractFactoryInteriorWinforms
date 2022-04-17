using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory {
    class ModernBed : Modern {
        public override Image GetImage()
        {
            return Image.FromFile("../../../Pictures/Modern/ModernBed.jpg");
        }

        public override string GetName() {
            return "ModernBed";
        }
    }
}
