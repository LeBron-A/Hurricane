using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Wind Speed (mph) ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    if (windSpeed <= 73.9) {
      Console.WriteLine("Not a Hurricane");
    }
    if (windSpeed >= 74.0 && windSpeed <= 95.9) {
      Console.WriteLine("Category one hurricane");
    }
    if (windSpeed >= 96.0 && windSpeed <= 110.9) {
      Console.WriteLine("Category two hurricane");
    }
    if (windSpeed >= 111.0 && windSpeed <= 129.9) {
      Console.WriteLine("Category three hurricane");
    }
    if (windSpeed >= 130.0 && windSpeed <= 156.9) {
      Console.WriteLine("Category four hurricane");
    }
    if (windSpeed >= 157.0) {
      Console.WriteLine("Category five hurricane");
    }
  }
}