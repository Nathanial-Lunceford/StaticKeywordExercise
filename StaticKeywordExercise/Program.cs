// See https://aka.ms/new-console-template for more information
using System;
using StaticKeywordExercise;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"40 Fahrenheit is {TempConverter.FahrenheitToCelcius(40)} Celsius, and " +
            $"32.22 Celsius is {TempConverter.CelciusToFahrenheit(32.22)} Fahrenheit");
    }
}