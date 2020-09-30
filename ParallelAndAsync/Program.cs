using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main1()
        {
            // TPL - Task Parallel Library

            int[] numbers = { 23, 45, 12, 56, 78, 43, 54, 65, 32, 21 };
            Stopwatch stopwatch = new Stopwatch();
            //Sequential
            stopwatch.Start();
            foreach (var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");

            // Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");

        }
        static void Compute(int x)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }

        static void Main2()
        {
            // Example : Making breakfast

            // Make Tea
            //-Turn on burner (2s)
            //-Put on kettle (1s)
            //-Add water (2s)
            //-Boil it (3min)
            //-Grid teas masala (10s)
            //-Add sugar and masalas (2s)
            //-Add milk (2s)
            //-Boil it (2min)

            // Fry eggs
            //-Turn on burner (2s)
            //-Put on pan (1s)
            //-Add oil (2s)
            //-Crack eggs and stir it (2min)
            //-Fry it (1min)

            // Everything ready: Serve it

            // Sequetial
            TurnOnBurner().Wait();
            Console.WriteLine("Burner1 turned on.");

            PutOn("Kettle").Wait();
            Console.WriteLine("Put kettle on burner.");

            Add("Water").Wait();
            Console.WriteLine("Added water on kettle.");

            Boil("Water").Wait();
            Console.WriteLine("Water boiled.");

            GrindTeaMasala().Wait();
            Console.WriteLine("Grinded tea masala.");

            Add("Sugar").Wait();
            Console.WriteLine("Added sugar.");

            Add("Masala").Wait();
            Console.WriteLine("Added masala.");

            Add("Milk").Wait();
            Console.WriteLine("Added milk.");

            Boil("Milk").Wait();
            Console.WriteLine("Boiled milk.");

            TurnOnBurner().Wait();
            Console.WriteLine("Burner2 turned on.");

            PutOn("Pan").Wait();
            Console.WriteLine("Put on pan.");

            Add("Oil").Wait();
            Console.WriteLine("Added oil.");

            CrackAndStirEggs().Wait();
            Console.WriteLine("Cracked and stirred eggs");

            FryEggs().Wait();
            Console.WriteLine("Fried eggs");

            Serve().Wait();
            Console.WriteLine("Served breakfast");
            
        }

        static async Task Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            
            var turnBurner1 = TurnOnBurner();
            var putKettle = PutOn("Kettle");
            var addWater = Add("Water");
            var boilWater = Boil("Water");
            var grindMasala = GrindTeaMasala();
            var addSugar = Add("Sugar");
            var addMasala = Add("Masala");
            var addMilk = Add("Milk");
            var boilMilk = Boil("Milk");
            var turnBurner2 = TurnOnBurner();
            var putPan = PutOn("Pan");
            var addOil = Add("Oil");
            var crackAndStirEggs = CrackAndStirEggs();
            var fryEggs = FryEggs();
            var serve = Serve();

            
            await turnBurner1;
            Console.WriteLine("Burner1 turned on.");

            await putKettle;
            Console.WriteLine("Put kettle on burner.");

            await addWater;
            Console.WriteLine("Added water on kettle.");

            await boilWater;
            Console.WriteLine("Water boiled.");

            await grindMasala;
            Console.WriteLine("Grinded tea masala.");

            await addSugar;
            Console.WriteLine("Added sugar.");

            await addMasala;
            Console.WriteLine("Added masala.");

            await addMilk;
            Console.WriteLine("Added milk.");

            await boilMilk;
            Console.WriteLine("Boiled milk.");

            await turnBurner2;
            Console.WriteLine("Burner2 turned on.");

            await putPan;
            Console.WriteLine("Put on pan.");

            await addOil;
            Console.WriteLine("Added oil.");

            await crackAndStirEggs;
            Console.WriteLine("Cracked and stirred eggs");

            await fryEggs;
            Console.WriteLine("Fried eggs");

            await serve;
            Console.WriteLine("Served breakfast");

            Console.WriteLine($"Time taken (Parallel): {sw.ElapsedMilliseconds} ms");

        }

        private static async Task Serve()
        {
            await Task.Delay(5000);
        }

        private static async Task FryEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task CrackAndStirEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task PutOn(string pot)
        {
            await Task.Delay(2000);
        }

        private static async Task TurnOnBurner()
        {
            await Task.Delay(2000);
        }

        private static async Task Add(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(10000);
        }

        private static async Task GrindTeaMasala()
        {
            await Task.Delay(10000);
        }

    }
}
