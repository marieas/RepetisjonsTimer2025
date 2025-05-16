using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinFørsteConsollApp
{
    internal class DiceMaster
    {
        Random random = new Random();
        int numberOfThrownNumberOne = 0;
        int numberOfThrownNumberTwos = 0;
        int numberOfThrows = 10;

        public void CompleteDiceThrows()
        {
            for (int i = 0; i < numberOfThrows; i++)
            {
                ThrowDiceAndIncStats();
            }
        }
        public void SetNumberOfThrows(int newNumberOfThrows)
        {
            numberOfThrows = newNumberOfThrows;
        }
        public void ShowAllStatistics()
        {
            Console.WriteLine($"You threw {numberOfThrownNumberOne} 1`s");
            Console.WriteLine($"You threw {numberOfThrownNumberTwos} 2`s");
        }

        void ThrowDiceAndIncStats()
        {
            var diceThrow = GetRandomDice();
            if (diceThrow == 1)
            {
                numberOfThrownNumberOne++;
            }
            else if (diceThrow == 2)
            {
                numberOfThrownNumberTwos++;
            }
            Console.WriteLine($"Dice shows: {diceThrow}");
        }
        int GetRandomDice()
        {
            int diceResult = random.Next(1, 7);
            return diceResult;
        }
    }
}
