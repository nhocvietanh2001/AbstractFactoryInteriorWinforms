using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractFactory {
    interface IFurniture {
        String GetName();
        Image GetImage();
    }
}
