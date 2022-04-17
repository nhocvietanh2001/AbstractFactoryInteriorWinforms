﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory {
    abstract class Traditional : IStyle {
        public abstract string GetName();
        public abstract Image GetImage();
    }
}
