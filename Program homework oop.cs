using System;

namespace HeroArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize integer array
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7 };
            // Initialize string array
            string[] strArr = { "string1", "string2", "string3" };

            // Create 10-element array with zeros and assign values to first two elements
            int[] intArr2 = new int[10];
            intArr2[0] = 10;
            intArr2[1] = 20;

            // Display the length of intArr
            Console.WriteLine(intArr.Length);

            // Display the first element of intArr2
            Console.WriteLine($"First element is {intArr2[0]}");

            // Initialize byte array and modify an element
            byte[] byteArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(string.Join(", ", byteArr));
            byteArr[5] = 100;
            Console.WriteLine(string.Join(", ", byteArr));

            // Initialize 2D byte array and assign values
            byte[,] arr2d = new byte[4, 5];
            arr2d[0, 0] = 1;
            arr2d[1, 1] = 2;
            arr2d[2, 2] = 3;
            arr2d[3, 3] = 4;
            arr2d[3, 1] = 2;

            // Display the total number of elements in the 2D array
            Console.WriteLine($"2D array length is {arr2d.Length}");

            // Print the 2D array
            for (int row = 0; row < arr2d.GetLength(0); row++)
            {
                for (int col = 0; col < arr2d.GetLength(1); col++)
                {
                    Console.Write(arr2d[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Create Hero objects and work with them
            Hero[] heroes = {
                new Warrior { Name = "Aragorn", Strength = 95 },
                new Mage { Name = "Gandalf", Mana = 120 },
                new Warrior { Name = "Boromir", Strength = 85 },
                new Mage { Name = "Saruman", Mana = 110 }
            };

            foreach (Hero hero in heroes)
            {
                hero.DisplayStats();
            }

            Console.ReadLine();
        }
    }

    // Base Hero class
    abstract class Hero
    {
        public string Name { get; set; }
        public abstract void DisplayStats();
    }

    // Warrior class inheriting from Hero
    class Warrior : Hero
    {
        public int Strength { get; set; }
        public override void DisplayStats()
        {
            Console.WriteLine($"Warrior {Name} has {Strength} strength.");
        }
    }

    // Mage class inheriting from Hero
    class Mage : Hero
    {
        public int Mana { get; set; }
        public override void DisplayStats()
        {
            Console.WriteLine($"Mage {Name} has {Mana} mana.");
        }
    }
}
