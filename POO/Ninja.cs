using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Deu um golpe";
        }
        
        public string Attack(int Bonus){
            if(Bonus > 9)
            {
                return this.Name + " atacou com um super golpe das sombras com bonus de " + Bonus;
            }else
            {
                return this.Name + " atacou o adversário mas não foi muito preciso com bonus de " + Bonus;
            }
        }    
    }
}