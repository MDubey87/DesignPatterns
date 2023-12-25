// See https://aka.ms/new-console-template for more information
// Existing OldPrinter
using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Target;

OldPrinter oldPrinter = new OldPrinter();

// Adapter to use OldPrinter as a NewPrinter
INewPrinter adaptedPrinter = new PrinterAdapter(oldPrinter);

// Using the NewPrinter interface
adaptedPrinter.PrintNew();
Console.ReadLine();
