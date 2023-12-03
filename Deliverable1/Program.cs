// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

int sodaCurrentStock = 100;
int chipsCurrentStock = 40;
int candyCurrentStock = 60;

int sodaRestockLimit = 40;
int chipsRestockLimit = 20;
int candyRestockLimit = 40;

Console.WriteLine("How many sodas have been sold today?");
int sodaSold = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many chips have been sold today?");
int chipsSold = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many candies have been sold today?");
int candySold = Convert.ToInt32(Console.ReadLine());