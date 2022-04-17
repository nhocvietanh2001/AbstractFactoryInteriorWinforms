using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory {
    class ModernDesk : Modern {
        public override Image GetImage()
        {
            return Image.FromFile("../../../Pictures/Modern/ModernDesk.jpg");
        }

        public override string GetName() {
            return "ModernDesk";
        }
    }
}
