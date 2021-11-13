using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEffect
{
    public class GameMaster
    {
        public GameMaster()
        {

        }

        public void PrintMainMenu()
        {
            Console.WriteLine("MENTAL EFFECT 1.0 \n");
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Instrukcja");
            Console.WriteLine("3. Autorzy");
            Console.WriteLine("4. Zakończ");
        }

        public void AskForInput()
        {
            Console.Write("Wybierz akcję: ");
        }

        public void PrintWrongInput()
        {
            Console.WriteLine("Wprowadzona wartość musi być numerem.");
        }
    }
}
