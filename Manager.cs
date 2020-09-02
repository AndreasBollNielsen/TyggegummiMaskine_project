using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Manager
    {
        // generate an dispenser
        Dispenser disp = new Dispenser();
        //method to remove gum from dispenser
        public void addgums()
        {
            disp.add(55);
        }

        public void removeGum()
        {
            disp.remove();
        }
    }
}
