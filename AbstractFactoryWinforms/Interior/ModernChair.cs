using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractFactory {
    class ModernChair : Modern {
        public override Image GetImage()
        {
            return Image.FromFile("../../../Pictures/Modern/ModernChair.jpg");
        }
        public override string GetName() {
            return "ModernChair";
        }
    }
}
