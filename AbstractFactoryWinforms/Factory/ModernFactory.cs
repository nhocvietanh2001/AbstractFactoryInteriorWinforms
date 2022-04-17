using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory {
    class ModernFactory : AbstractStyleFactory {
        public override IStyle CreateDesk() {
            return new ModernDesk();
        }
        public override IStyle CreateChair() {
            return new ModernChair();
        }
        public override IStyle CreateBed() {
            return new ModernBed();
        }
        public override IStyle CreateStyle() {
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
        public override List<IStyle> CreateSet() {
            List<IStyle> set = new List<IStyle>();
            set.Add(new ModernDesk());
            set.Add(new ModernChair());
            return set;
        }
    }
}
