using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //add manager and call add gums method from dispenser
            Manager man = new Manager();
            man.addgums();

            Console.ReadKey();
        }
    }
}
