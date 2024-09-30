using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int choice;

        do
        {
            Console.WriteLine("Welcome to Crimson Crust Pizza!");
            Console.WriteLine("Enter 1 to display a plain topping-less pizza slice");
            Console.WriteLine("Enter 2 to display cheese pizza slice");
            Console.WriteLine("Enter 3 to display pepperoni pizza slice");
            Console.WriteLine("Enter 4 to exit");

            
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayPlainPizza();
                        break;
                    case 2:
                        DisplayCheesePizza();
                        break;
                    case 3:
                        DisplayPepperoniPizza(random);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for visiting Crimson Crust!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
            }

            Console.WriteLine(); 
        } while (choice != 4);
    }

    
    static void DisplayPlainPizza()
    {
        int rows = new Random().Next(8, 13); 
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); 
        }
    }

    
    static void DisplayCheesePizza()
    {
        int rows = new Random().Next(8, 13); 
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (i == rows || j == 0 || j == i - 1) 
                {
                    Console.Write("* ");
                }
                else 
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine(); 
        }
    }

    
    static void DisplayPepperoniPizza(Random random)
    {
        int rows = new Random().Next(8, 13); 
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (i == rows || j == 0 || j == i - 1) 
                {
                    Console.Write("* ");
                }
                else 
                {
                    
                    if (random.Next(2) == 0) 
                    {
                        Console.Write("[] "); 
                    }
                    else
                    {
                        Console.Write("# "); 
                    }
                }
            }
            Console.WriteLine(); 
        }
    }
}
