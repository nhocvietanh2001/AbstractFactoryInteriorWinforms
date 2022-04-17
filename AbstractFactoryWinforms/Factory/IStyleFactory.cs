using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    internal interface IStyleFactory {
        IStyle CreateStyle();
        IStyle CreateDesk();
        IStyle CreateChair();
        IStyle CreateBed();
        List<IStyle> CreateSet();
    }
}
