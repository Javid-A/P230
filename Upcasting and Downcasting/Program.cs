namespace Upcasting_and_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intNum = 123;

            //byte byteNum = (byte)intNum;
            //Console.WriteLine(byteNum);
            //Samoyed samoyed = new Samoyed();
            //LionFish fish = new LionFish();
            ////Console.WriteLine(samoyed.GetType());
            ////Console.WriteLine(fish.GetType());

            //Animal animal = new Samoyed();

            //Dog dog = new Samoyed();
            //Console.WriteLine(animal.GetType().GetProperties());
            //Console.WriteLine(samoyed);
            //Console.WriteLine(dog);



            //Animal animal = new LionFish();


            //LionFish fish = animal as LionFish;

            //if (fish != null)
            //{
            //    fish.Poison = "Deadly";
            //    Console.WriteLine(fish.Poison);
            //}

            //Console.WriteLine(fish == null);


            //if (animal is LionFish exFish)
            //{
            //    LionFish fish = exFish;
            //    fish.Poison = "Deadly";
            //    Console.WriteLine(fish.Poison);
            //}


            Samoyed samoyed = new Samoyed();
            Pitbull pitbull = new Pitbull();
            samoyed.Fur = "Fury";
            //TreatPitbull(pitbull);
            //TreatSamoyed(samoyed);

            //Console.WriteLine("Before treat");
            //Console.WriteLine(samoyed.Fur);
            //TreatDogs(samoyed);
            //Console.WriteLine("After treat");
            //Console.WriteLine(samoyed.Fur);
            //TreatDogs(pitbull);
            //Dog dog = new Pitbull();
            TreatDogs(new Husky());
        }

        static void TreatSamoyed(Samoyed samoyed)
        {
            Console.WriteLine(samoyed.GetType());
            Console.WriteLine("Some treating process");
        }
        static void TreatPitbull(Pitbull pitbull)
        {
            Console.WriteLine(pitbull.GetType());
            Console.WriteLine("Some treating process");
        }

        static void TreatDogs(Dog dog)
        {
            Console.WriteLine(dog.GetType());
            if (dog is IShaveable samoyed)
            {
                samoyed.Shave();
            }

            //IShaveable shaveable = (IShaveable)dog;// worst version
            //shaveable.Shave();
            Console.WriteLine("Some treating process");
        }
    }
}