﻿using System;

namespace console_programlama
{
class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Hello world");
         Console.WriteLine("Başlayalım...");
        Console.WriteLine("İsminizi giriniz: ");
        string name=Console.ReadLine();
        Console.WriteLine("Soyadınızı giriniz: ");
        string surname=Console.ReadLine();
        Console.WriteLine("Merhaba " + name + " " + surname);
    
    }
}
}