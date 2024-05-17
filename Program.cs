namespace Working_with_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN ="A1", make = "Volvo", model= "550i", StickerPrice=55000, year= 1899 },
            new Car() { VIN = "B2", make = "BMW", model = "4Runner", StickerPrice = 55000, year = 1799 },
            new Car() { VIN = "C3", make = "Nissan", model = "745li", StickerPrice = 55000, year = 1739 },
            new Car() { VIN = "D4", make = "Toyota", model = "Escape", StickerPrice = 55000, year = 1459 },
            new Car() { VIN = "E5", make = "Benz", model = "55i", StickerPrice = 55000, year = 1029 }
            };

            // LINQ query
            /*
            var Volvos = from car in myCars
                         where car.make == "Volvo"
                         && car.year == 1899
                         select car;
            */

            /*
            var orderdCars = from car in myCars
                             orderby car.year descending
                             select car;
            */
            //LINQ method

            //   var Volvos = myCars.Where(p => p.make == "Volvo" && p.year == 1899);

            // var orderedCars = myCars.OrderByDescending(p => p.year);
            /*
            var firstVolvo =myCars.OrderByDescending(p => p.make).First(p => p.make == "Volvo");
            Console.WriteLine(firstVolvo.VIN);
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.year > 2007));


            // myCars.ForEach(p => p.StickerPrice -= 3000);
            // myCars.ForEach(p => Console.Write("{0}, {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.model == "Escape"));

            // Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /*
            foreach (var car in orderedCars )
            {
                Console.WriteLine("{0} {1}", car.year, car.model, car.VIN);
            }
       */
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.year);
            Console.WriteLine(orderedCars.GetType());
           
            var Volvos = myCars.Where(p => p.make == "Volvo" && p.year == 1899);
            Console.WriteLine(Volvos.GetType());
           
            var newCars = from car in myCars
                          where car.make == "Volvo"
                          && car.year == 1899
                          select new{ car.make, car.model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }
        
           class Car
        {
            public string VIN { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public int year { get; set; }
            public double StickerPrice { get; set; }

        }
        }
    

