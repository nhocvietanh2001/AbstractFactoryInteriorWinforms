using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    class TraditionalFactory : AbstractStyleFactory {
        public override IFurniture CreateDesk() {
            return new TraditionalDesk();
        }
        public override IFurniture CreateChair() {
            return new TraditionalChair();
        }
        public override IFurniture CreateBed() {
            return new TraditionalBed();
        }
        public override IFurniture CreateFurniture() {
            Random random = new Random();
            int interior = random.Next(0, 3);
            if (interior == 0) {
                return new TraditionalDesk();
            }
            else {
                if (interior == 1)
                    return new TraditionalChair();
                else
                    return new TraditionalBed();
            }
        }
        public override List<IFurniture> CreateSet() {
            List<IFurniture> set = new List<IFurniture>();
            set.Add(new TraditionalDesk());
            set.Add(new TraditionalChair());
            return set;
        }

        
    }
}
