/*
 *   
Tema: Klasser/object
Pause til 13.00

OPPGAVE: 
Dersom vi ønsker å velge spesifikt hvilket tall vi skal få statistikk for?
*/

using MinFørsteConsollApp;
DiceMaster diceMaster = new DiceMaster();

MainMenu();
void MainMenu()
{
    Console.WriteLine("Welcome to the DICE THROWER! We will now throw the dice!");
    Console.WriteLine("1. Choose number of dice throws (10 if nothing is specified)");
    Console.WriteLine("2. Show All statistics");
    Console.WriteLine("3. Show Specific statistic");

    var menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            ChooseNumberOfDiceThrows();
            diceMaster.CompleteDiceThrows();
        break;
        case "2":
            diceMaster.CompleteDiceThrows();
            diceMaster.ShowAllStatistics();
            break;
    }
}

void ChooseNumberOfDiceThrows()//Parameter => når vi ønsker å sende data INN til en funksjon
{
    Console.WriteLine("What number of throws?");
    var numberOfThrows = int.Parse(Console.ReadLine());
    diceMaster.SetNumberOfThrows(numberOfThrows);
    //return numberOfThrows; -> RETURVERDI NÅR VI ØNSKER Å SENDE DATA UT AV FUNKSJON
}




