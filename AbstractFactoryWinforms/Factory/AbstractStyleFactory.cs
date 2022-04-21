using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    abstract class AbstractStyleFactory : IStyleFactory{
        abstract public IFurniture CreateFurniture();
        abstract public IFurniture CreateDesk();
        abstract public IFurniture CreateChair();
        abstract public IFurniture CreateBed();
        abstract public List<IFurniture> CreateSet();
    }
}
