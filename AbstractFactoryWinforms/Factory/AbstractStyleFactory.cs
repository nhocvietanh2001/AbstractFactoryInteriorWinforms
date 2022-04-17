using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    abstract class AbstractStyleFactory : IStyleFactory{
        abstract public IStyle CreateStyle();
        abstract public IStyle CreateDesk();
        abstract public IStyle CreateChair();
        abstract public IStyle CreateBed();
        abstract public List<IStyle> CreateSet();
    }
}
