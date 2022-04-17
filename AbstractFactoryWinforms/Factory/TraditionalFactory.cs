using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    class TraditionalFactory : AbstractStyleFactory {
        public override IStyle CreateDesk() {
            return new TraditionalDesk();
        }
        public override IStyle CreateChair() {
            return new TraditionalChair();
        }
        public override IStyle CreateBed() {
            return new TraditionalBed();
        }
        public override IStyle CreateStyle() {
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
        public override List<IStyle> CreateSet() {
            List<IStyle> set = new List<IStyle>();
            set.Add(new TraditionalDesk());
            set.Add(new TraditionalChair());
            return set;
        }

        
    }
}
