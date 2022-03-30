using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public override string Attack()
        {
            return this.Name + " atacou com a espada";
        }
        
        public string Attack(int Bonus){
            if(Bonus > 5)
            {
                return this.Name + " atacou e acertou a cabeça do inimigo com bonus de " + Bonus;
            }else
            {
                return this.Name + " atacou o adversário mas não foi muito preciso com bonus de " + Bonus;
            }
        }    
    }
}