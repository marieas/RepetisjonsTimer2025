// See https://aka.ms/new-console-template for more information

/*
 * * Pause til 13.10 
Repetisjon: Sterk typing, Returverdi, Console.WriteLine(), Console.ReadLine()
Nytt: Math.Random() (EVT + løkke & if/else i C#)
 
string name = "Marie";
int number = 0;
double linn = 1.3;
float rebecka = 11.34f;
decimal marius = 23.35m;
var bjarne = true;
char bokstav = 'b';

OPPGAVE - Vi ser hvor langt vi kommer: 
 1. Vi skal lage en app som kaster en terning og printer ut hva resultatet var
 2. Hvordan tar vi vare på statistikk for hvor mange 1`ere man har fått?
 3. Statistikk for de andre mulige tallene 
 4. Dersom vi ønsker terningen skal kastes 10 ganger og så printe statistikken?
 5. Dersom vi ønsker at brukeren kan bestemme hvor mange gangen terningen skal kastes før statistikken vises?
 6. Dersom vi ønsker å velge spesifikt hvilket tall vi skal få statistikk for?
*/

Random random = new Random();
ThrowDice();
void ThrowDice()
{
    Console.WriteLine("Welcome to the DICE THROWER! We will now throw the dice!");
    int numberOfThrownNumberOne = 0;

    for (int i = 0; i<10; i++) 
    {
        var diceThrow = GetRandomDice();
        if(diceThrow == 1)
        {
            numberOfThrownNumberOne++;
        }
        Console.WriteLine($"Dice shows: {diceThrow}");
    }

    Console.WriteLine($"You threw {numberOfThrownNumberOne} 1`s");
}
int GetRandomDice()
{
    int diceResult = random.Next(1, 7);
    return diceResult;
}


