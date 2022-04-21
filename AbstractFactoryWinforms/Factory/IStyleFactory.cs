using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    internal interface IStyleFactory {
        IFurniture CreateFurniture();
        IFurniture CreateDesk();
        IFurniture CreateChair();
        IFurniture CreateBed();
        List<IFurniture> CreateSet();
    }
}
