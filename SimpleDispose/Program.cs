﻿using SimpleDispose;

Console.WriteLine("***** Fun with Dispose *****\n");

// Create a disposable object and call Dispose()
// to free any internal resources.
//MyResourceWrapper rw = new MyResourceWrapper();

//if (rw is IDisposable)
//{
//	rw.Dispose();
//}

// Dispose() is called automatically when the using scope exits.
using (MyResourceWrapper rw = new MyResourceWrapper())
{
	// Use rw object.
}

Console.WriteLine("Demonstrate using declarations");
UsingDeclaration();
Console.ReadLine();

Console.ReadLine();


static void DisposeFileStream()
{
	FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);
	// Confusing, to say the least!
	// These method calls do the same thing!
	fs.Close();
	fs.Dispose();
}

static void UsingDeclaration()
{
	//This variable will be in scope until the end of the method
	using var rw = new MyResourceWrapper();
	//Do something here
	Console.WriteLine("About to dispose.");
	//Variable is disposed at this point.
}