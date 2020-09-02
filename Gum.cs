using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Gum
    {
        //private fields
        public enum Flavors { Blueberry, Rasberry, TuttiFrutti,Orange,Strawberry,Apple};
        private Flavors flavor;
       
        //public properties
        public Flavors Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        
        //constructor
        public Gum(Flavors _flavor)
        {
            this.flavor = _flavor;
        }
    }
}
