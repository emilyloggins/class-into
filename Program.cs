using System;
using System.Collections.Generic;
using ClassIntro;

namespace randalls_car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
var ford = new Dictionary<string, string>()
{
    {"Year", "1914"},
    {"Make", "Ford"},
    {"Model", "T"},
    {"Price", "300"}
};
var tesla = new Dictionary<string, string>()
{
    {"Year", "2017"},
    {"Make", "Tesla"},
    {"Model", "x"},
    {"Price", "80000.45"}
};

List<Dictionary<string, string>> garage = new List<Dictionary<string, string>>();

garage.Add(ford);
garage.Add(tesla);

        var ford2 = new Car();
        ford2.Year = 2017;
        ford2.Model = "Fiesta";
        ford2.Make = "Ford";
        ford2.Price = 22500.52;

        var tesla2 = new Car()
        {
            Year = 2017,
            Model = "x",
            Make = "Tesla",
            Price = 3.89
        };

        var garage2 = new List<Car>() { ford2, tesla2 };

        ford2.Drive();
    }
}
}
