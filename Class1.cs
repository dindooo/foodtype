using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class foodType
    {
        string name;
        int protein;
        int carbs;
        int fat;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setProtein(int protein)
        {
            this.protein = protein;
        }
        public int getProtein()
        {
            return this.protein;
        }
        public void setCarbs(int carbs)
        {
            this.carbs = carbs; 
        }
        public int getCarbs()
        {
            return this.carbs;
        }
        public void setFat(int fat)
        {
            this.fat = fat; 
        }
        public int getFat()
        {
            return this.fat;
        }
        public foodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }
        public override string ToString()
        {
            string ispis = "Naziv " + this.getName()
            + " Proteini " + this.getProtein()
            + " Carbs " + this.getCarbs()
            + " Fat " + this.getFat();
            return ispis;
        }

        public foodType()
        {

        }

       

    }

    
}
