using System;

namespace MentalEffect
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMaster gameMaster = new GameMaster();

            gameMaster.PrintMainMenu();
            gameMaster.AskForInput();
            string wayOfAction = Console.ReadLine();

            if (int.TryParse(wayOfAction, out int wayOfActionNumber))
            {
                
            }
            else
            {
                gameMaster.PrintWrongInput();
            }
        }
    }
}
