using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    class ModernFactory : AbstractStyleFactory {
        public override IFurniture CreateDesk() {
            return new ModernDesk();
        }
        public override IFurniture CreateChair() {
            return new ModernChair();
        }
        public override IFurniture CreateBed() {
            return new ModernBed();
        }
        public override IFurniture CreateFurniture() {
            Random random = new Random();
            int interior = random.Next(0, 3);
            if (interior == 0) {
                return new ModernDesk();
            }
            else {
                if (interior == 1)
                    return new ModernChair();
                else 
                    return new ModernBed();
            }
        }
        public override List<IFurniture> CreateSet() {
            List<IFurniture> set = new List<IFurniture>();
            set.Add(new ModernDesk());
            set.Add(new ModernChair());
            return set;
        }
    }
}
