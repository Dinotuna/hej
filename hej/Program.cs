// See https://aka.ms/new-console-template for more information

using System;

string name = "";
string favoritesport = "";
string petname = "";


Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine("Vad är din favorit sport?");
favoritesport = Console.ReadLine();

Console.WriteLine("Vad heter ditt husdjur?");
petname = Console.ReadLine();

Console.WriteLine($"Hej {name} du är bajs på {favoritesport} och {petname} gillar inte dig");

Console.WriteLine("Klicka ENTER för att avsluta");
Console.ReadLine();

Console.WriteLine($"Hejdå {name}");

Console.ReadLine();


