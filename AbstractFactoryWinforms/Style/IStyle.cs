using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractFactory {
    interface IStyle {
        String GetName();
        Image GetImage();
    }
}
