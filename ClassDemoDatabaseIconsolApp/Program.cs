// See https://aka.ms/new-console-template for more information
using ClassDemoDatabaseIconsolApp;
using ClassDemoDatabaseIconsolApp.model;

Console.WriteLine("Hello, World!");


DB_Drink drinkRepo = new DB_Drink();
Udskriv();

Console.WriteLine(  "Ny drink");
Drink nydrink = new Drink(666, "dark storm", true);
drinkRepo.Add(nydrink);
Udskriv();

void Udskriv()
{
    List<Drink> drinks = drinkRepo.GetAll();
    foreach (Drink drink in drinks)
    {
        Console.WriteLine(drink);
    }
}