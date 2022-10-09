// See https://aka.ms/new-console-template for more information
using Opdracht2;
using System;

Koe eersteKoe = new Koe();
Slang eersteSlang = new Slang();
Varken eersteVarken = new Varken();

Console.WriteLine("console applicatie Huisdieren");

Console.WriteLine("Een koe zijn uispraak is '" + eersteKoe.Zegt() + "' , en weegt " + eersteKoe.gewicht + "kg.");
Console.WriteLine("Een slang zijn uispraak is '" + eersteSlang.Zegt() + "' , en weegt " + eersteSlang.gewicht + "kg.");
Console.WriteLine("Een varken zijn uispraak is '" + eersteVarken.Zegt() + "' , en weegt " + eersteVarken.gewicht + "kg.");
