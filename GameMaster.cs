using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalEffect.Characters;
using MentalEffect.Characters.Player;

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
            Console.WriteLine("1 - Nowa gra");
            Console.WriteLine("2 - Instrukcja");
            Console.WriteLine("3 - Zakończ");
        }

        private void PrintCharacterSelection()
        {
            Console.WriteLine("Wybierz klasę postaci: ");
            Console.WriteLine("1 - ");
            PrintCharacterInfo(new Warrior());
        }

        private void PrintCharacterInfo(Character playerCharacter)
        {
            Console.WriteLine($"KLASA: {playerCharacter.ClassName}");
            Console.WriteLine($"ŻYCIE: {playerCharacter.HealthValue}");
            Console.WriteLine($"ATAK: {playerCharacter.AttackValue}");
            Console.WriteLine($"OBRONA: {playerCharacter.HealthValue}");
        }

        public void AskForInput()
        {
            Console.Write("Wybierz akcję: ");
        }

        public void PrintWrongInput()
        {
            Console.WriteLine("Wprowadzona wartość musi być numerem.\n");
        }
        public void PrintWrongNumberInput()
        {
            Console.WriteLine("Wprowadzona wartośc jest poza zakresem.\n");
        }

        public Character CreateCharacter()
        {
            Character playerCharacter = null;          

            while (true)
            {
                PrintCharacterSelection();
                string wayOfAction = Console.ReadLine();

                if (int.TryParse(wayOfAction, out int wayOfActionNumber))
                {
                    if (wayOfActionNumber == 1)
                    {
                        playerCharacter = new Warrior();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        PrintWrongNumberInput();                    
                    }
                }
                else
                {
                    Console.Clear();
                    PrintWrongInput();
                }
            }
            
            return playerCharacter;
        }

        public void StartGame()
        {
            // Create character
            Character playerCharacter = CreateCharacter();
            PrintCharacterInfo(playerCharacter);
        }
    }
}
