namespace Upcasting_and_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting & Downcasting
            //int intNum = 123;

            //double number = 10.5;

            //int numberInt = (int)number;

            //Console.WriteLine(numberInt);

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



            //Samoyed samoyed1 = new Samoyed();
            //LionFish fish = animal as LionFish;

            //bool result = animal is LionFish;



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

            //Samoyed samoyed = new Samoyed();
            //Pitbull pitbull = new Pitbull();
            //samoyed.Fur = "Fury";
            //TreatPitbull(pitbull);
            //TreatSamoyed(samoyed);

            //Console.WriteLine("Before treat");
            //Console.WriteLine(samoyed.Fur);
            //TreatDogs(samoyed);
            //Console.WriteLine("After treat");
            //Console.WriteLine(samoyed.Fur);
            //TreatDogs(pitbull);
            //Dog dog = new Pitbull();
            //Console.WriteLine(samoyed.Fur);
            //TreatDogs(samoyed); 
            #endregion

            //Manat manat = new Manat { AZN = 400 };



            //Dollar dollar = new Dollar();

            //dollar = manat;



            //Person person1 = new Person(20);
            //Person person2 = new Person(30);
            //Person person3 = new Person(40);


            //Console.WriteLine(person1+person2);
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
                IShaveable shaveable = (IShaveable)dog;
                samoyed.Shave();
            }

            //IShaveable shaveable = (IShaveable)dog;// worst version
            //shaveable.Shave();
            Console.WriteLine("Some treating process");
        }
    }


    class Currency
    {

    }
    class Manat
    {
        public double AZN { get; set; }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar { USD = manat.AZN / 2 };
        }

    }

    class Dollar
    {
        public double USD { get; set; }

        
    }


    class Person
    {
        public byte Age { get; set; }

        public Person(byte age)
        {
            Age = age;
        }


        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }
        public static int operator -(Person p1, Person p2)
        {
            return p1.Age - p2.Age;
        }
    }
}