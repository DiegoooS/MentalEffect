using System;

namespace MentalEffect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set GameMaster object to control the game
            GameMaster gameMaster = new GameMaster();

            // Creat Main Menu
            MainMenu(gameMaster);
        }

        private static void MainMenu(GameMaster gameMaster)
        {
            int wayOfActionNumber = 0;

            while (wayOfActionNumber != 3)
            {
                gameMaster.PrintMainMenu();
                gameMaster.AskForInput();
                string wayOfAction = Console.ReadLine();

                if (int.TryParse(wayOfAction, out wayOfActionNumber))
                {
                    switch (wayOfActionNumber)
                    {
                        case 1:
                            {
                                gameMaster.StartGame();
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                gameMaster.PrintWrongNumberInput();
                                break;
                            }
                    }
                }
                else
                {
                    Console.Clear();
                    gameMaster.PrintWrongInput();
                }
            }
        }


    }
}
