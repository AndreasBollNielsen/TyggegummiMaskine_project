using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Dispenser
    {
        private int number_of_gums;
        private List<Gum> gums;

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

        //empty 
        public Dispenser()
        {
            this.gums = new List<Gum>();
        }

        /// <summary>
        /// Add gums to the dispenser
        /// </summary>
        /// <param name="amount">amount of gums</param>
        public void add(int amount)
        {

            List<int> flavortypes = flavormixer(amount);
            Random randgen = new Random();
            Console.WriteLine(flavortypes.Count);

            for (int i = 0; i < amount; i++)
            {
                int flavorNumb = randgen.Next(0, 3);
              
                flavortypes[flavorNumb] -= 1;

                if (flavortypes[flavorNumb] > 0)
                {
                    gums.Add(new Gum((Gum.Flavors)flavorNumb));

                }

            }
            flavortypes.Clear();
            updatenumber();
        }

        /// <summary>
        /// Remove a gum from dispenser
        /// </summary>
        /// <returns></returns>
        public Gum remove()
        {
            Random rand = new Random();
            int randgum = rand.Next();

            Gum extractedGum = gums[randgum];
            gums.RemoveAt(randgum);
            updatenumber();
            return extractedGum;
        }

        private void updatenumber()
        {
            number_of_gums = gums.Count;
        }

        private List<int> flavormixer(int amount)
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
            output[numb] -=1;
            return output;
        }
    }
}
