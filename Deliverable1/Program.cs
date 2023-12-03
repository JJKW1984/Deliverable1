// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

int sodaCurrentStock = 100;
int chipsCurrentStock = 40;
int candyCurrentStock = 60;

int sodaRestockLimit = 40;
int chipsRestockLimit = 20;
int candyRestockLimit = 40;

int sodaSold;
int chipsSold;
int candySold;


//check current stock
//terrible way to iterate through the items, but it work
//This should be a class and a function

Console.WriteLine("Welcome to thew restocking tool.");

Console.WriteLine("How many sodas have been sold today?" + " " + sodaCurrentStock + " currently in stock");
sodaSold = Convert.ToInt32(Console.ReadLine());

if (sodaSold > sodaCurrentStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");

}
else
{
    sodaCurrentStock = sodaCurrentStock - sodaSold;
    Console.WriteLine("There are " + sodaCurrentStock + " Sodas left");
}

Console.WriteLine("How many chips have been sold today?" + " " + chipsCurrentStock + " currently in stock");
chipsSold = Convert.ToInt32(Console.ReadLine());

if (chipsSold > chipsCurrentStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");
}
else
{
    chipsCurrentStock = chipsCurrentStock - chipsSold;
    Console.WriteLine("There are " + chipsCurrentStock + " Chips left");
}

Console.WriteLine("How many candy have been sold today?" + " " + candyCurrentStock + " currently in stock");
candySold = Convert.ToInt32(Console.ReadLine());

if (candySold > candyCurrentStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");
}
else
{
    candyCurrentStock = candyCurrentStock - candySold;
    Console.WriteLine("There are " + candyCurrentStock + " Candy left");
}

//check if it is time to restock
Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");

if (sodaCurrentStock < sodaRestockLimit)
{
    Console.WriteLine("Soda needs to be restocked");
}

if (chipsCurrentStock < chipsRestockLimit)
{
    Console.WriteLine("Chips needs to be restocked");
}

if (candyCurrentStock < candyRestockLimit)
{
    Console.WriteLine("Candy needs to be restocked");
}