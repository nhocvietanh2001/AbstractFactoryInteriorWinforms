using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory {
    class TraditionalBed : Traditional {
        public override Image GetImage()
        {
            return Image.FromFile("../../../Pictures/Traditional/TraditionalBed.jpg");
        }

        public override string GetName() {
            return "TraditionalBed";
        }
    }
}