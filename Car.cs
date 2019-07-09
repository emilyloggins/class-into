using System;

namespace ClassIntro {

            class Car
            {
                public int Year { get; set; }
                public string Model { get; set; }
                public string Make { get; set; }
                public double Price { get; set; }

                public void Drive()
                {
                    Console.WriteLine($"Hey, I'm drivin' here!!! This {Make} costs {Price} dollars!!!");
                }
}
}