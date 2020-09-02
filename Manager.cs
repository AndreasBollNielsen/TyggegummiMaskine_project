using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Manager
    {
        public List<Dispenser> Dispensers;
        public List<Gum> Sparegums;

        // generate an dispenser
        public Dispenser disp = new Dispenser();

        //constructor of manager
        public Manager()
        {
            Dispensers = new List<Dispenser>();
            Dispenser disp = new Dispenser();
            Sparegums = new List<Gum>();
            Dispensers.Add(disp);
        }

        //method to remove gum from dispenser
        public void Addgums()
        {
            disp.Gums = disp.Add(5);
            disp.Updatenumber();
        }

        //refill dispenser
        public void AddAditionalgums()
        {
            // add spare gums to dispenser if available
            for (int i = 0; i < Sparegums.Count; i++)
            {
                if(disp.Gums.Count <55)
                {
                    disp.Gums.Add(Sparegums[i]);
                    Sparegums.RemoveAt(i);
                    i--;
                }
               
            }

            //add spare gums to list
            int totalgums = disp.Number_of_gums + 55;
            int to_spare = totalgums - 55;
            Sparegums = disp.Add(to_spare);

            //add 55 new gums
            int to_dispenser = 55 - to_spare;
            disp.Gums = disp.Add(to_dispenser);
            Console.WriteLine(disp.Gums.Count);
            disp.Updatenumber();
        }

        //remove gum from dispenser
        public string RemoveGum()
        {
            Gum extractedgum = disp.Remove();

            string flavor = extractedgum.Flavor.ToString();
            return flavor;

        }
    }
}
