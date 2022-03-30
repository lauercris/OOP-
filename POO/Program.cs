using System;

namespace POO
{
    class program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Kinight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 50, "Black Wizard");

            Console.WriteLine(topapa.Attack(1));
            Console.WriteLine(topapa.Attack(10));
            //Criando método construtor do herói
        }
    }
}