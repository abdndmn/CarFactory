using CarFactory;

class Program
{
    static void Main(string[] args)
    {

        List<Car> cars = new List<Car>();

        while (true)
        {
            Console.WriteLine("Araba üretmek istiyor musunuz? (E/H):");
            string answer = Console.ReadLine().ToUpper();
            
            if (answer == "E")
            {
                Car car = new Car();

                car.ProductionDate = DateTime.Now;
                Console.WriteLine("Arabanın seri numarsını giriniz!");
                car.SerialNumber = Console.ReadLine();
                Console.WriteLine("Arabanın markasını giriniz!");
                car.Brand = Console.ReadLine();
                Console.WriteLine("Arabanın modelini giriniz!");
                car.Model = Console.ReadLine();
                Console.WriteLine("Arabanın rengini giriniz!");
                car.Color = Console.ReadLine();

                int userInput;
                Console.WriteLine("Arabanın kapı sayısını giriniz!");
                carDoorLoop:
                    
                    try
                    {

                        car.DoorCount = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen sadece bir tam sayı giriniz.");
                        goto carDoorLoop;
                    }
                cars.Add(car);
                Console.WriteLine("Araba üretildi!");



            }
            else if (answer == "H")
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;

            }
            else
            {
                Console.WriteLine("Hatalı giriş!");

            }

        }
       
        if (cars.Count != 0)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}");
            }

        }





    }
}

        