using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Dispenser
    {
        //private fields
        private int number_of_gums;
        private List<Gum> gums;

        //public properties
        public int Number_of_gums
        {
            get { return number_of_gums; }
            set { number_of_gums = value; }
        }
        public List<Gum> Gums
        {
            get { return gums; }
            set { gums = value; }
        }

        //initialize list
        public Dispenser()
        {
            this.gums = new List<Gum>();
        }

        // Add gums to the dispenser
        public List<Gum> Add(int amount)
        {
            List<int> flavortypes = Flavormixer(amount);
            List<Gum> tempgums = new List<Gum>();
            Random randgen = new Random();

            int numbflavors = flavortypes.Count;
            for (int i = 0; i < amount; i++)
            {
                int flavorNumb = randgen.Next(0, numbflavors);

                if (flavortypes.Count > 0)
                {
                    if (flavortypes[flavorNumb] > 0)
                    {
                        flavortypes[flavorNumb] -= 1;
                        tempgums.Add(new Gum((Gum.Flavors)flavorNumb));

                    }
                    else
                    {
                        flavortypes.RemoveAt(flavorNumb);
                        numbflavors = flavortypes.Count;
                        i--;
                    }
                }


            }
            flavortypes.Clear();
            Updatenumber();
            return tempgums;
        }


        // Remove a gum from dispenser
        public Gum Remove()
        {
            if (gums.Count > 0)
            {
                Random rand = new Random();
                int randgum = rand.Next(0, gums.Count);

                Gum extractedGum = gums[randgum];
                gums.RemoveAt(randgum);
                Updatenumber();
                return extractedGum;
            }
            else
            {
                return null;
            }

        }

        //method to update the number of gums in the dispenser
        public void Updatenumber()
        {
            number_of_gums = gums.Count;
        }

        //returns a list of mixed flavors
        public List<int> Flavormixer(int amount)
        {
            double blueberries = Math.Round(amount / 100f * 25);
            double rasberries = Math.Round(amount / 100f * 12);
            double tuttifrutti = Math.Round(amount / 100f * 20);
            double orange = Math.Round(amount / 100f * 19);
            double strawberry = Math.Round(amount / 100f * 14);
            double apple = Math.Round(amount / 100f * 10);

            List<int> output = new List<int> { (int)blueberries, (int)rasberries, (int)tuttifrutti, (int)orange, (int)strawberry, (int)apple };
            Random rand = new Random();
            int numb = rand.Next(0, 6);

            output[numb] -= 1;

            return output;
        }
    }
}
