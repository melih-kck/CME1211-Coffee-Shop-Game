using System;

namespace CME_1211_ALGORITHMS_AND_PROGRAMMING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int currentDay = 1;
            int dailyOrders = 0;
            int availableCoffeeShots = 0;
            int freshCoffee = 0;
            int croissantBoxes = 0;
            int croissantsReady = 0;
            bool isGameRunning = true;
            bool firstTime = true;

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Coffee Shop!");
            Console.ResetColor();

            // Main game loop
            while (isGameRunning)
            {
                int choice;
                int amount;
                bool endDay = false;

                if (firstTime == false)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                }

                // Current status
                Console.Write("Your current capital is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(money + "Z");
                Console.ResetColor();
                Console.WriteLine(".");

                Console.Write("The number of working days is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(currentDay);
                Console.ResetColor();
                Console.WriteLine(".");

                // Main menu
                Console.WriteLine("Please select the option you want to apply:");
                Console.WriteLine("1. Buy coffee package");
                Console.WriteLine("2. Brew coffee");
                Console.WriteLine("3. Sell cup(s) of coffee");
                Console.WriteLine("4. Buy package(s) of Croissant");
                Console.WriteLine("5. Open 1 package of Croissant");
                Console.WriteLine("6. Sell Croissants");
                Console.WriteLine("7. End of the Day >");
                Console.WriteLine("8. Quit Game");
                Console.Write("Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (money < 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: Insufficient balance to buy a coffee package!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Operation is processed! Please enter the number of packages to buy:");
                            Console.Write("Choice: ");
                            amount = Convert.ToInt32(Console.ReadLine());

                            while (amount <= 0 || amount > money / 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                if (amount <= 0)
                                {
                                    Console.WriteLine("Warning: The number of packages must be greater than zero. Please re-enter:");
                                }
                                else
                                {
                                    Console.WriteLine("Warning: Insufficient balance! Please re-enter the number of packages to buy:");
                                }

                                Console.ResetColor();
                                Console.Write("Choice: ");
                                amount = Convert.ToInt32(Console.ReadLine());
                            }

                            money = money - (amount * 5);
                            availableCoffeeShots = availableCoffeeShots + (amount * 3);

                            Console.Write("Operation is processed! Now, you have ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(availableCoffeeShots);
                            Console.ResetColor();
                            Console.WriteLine(" shots of coffee to brew.");
                        }
                        break;

                    case 2:
                        if (availableCoffeeShots == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: You have no coffee shots to brew!");
                            Console.ResetColor();
                        }
                        else
                        {
                            availableCoffeeShots = availableCoffeeShots - 1;
                            freshCoffee = freshCoffee + 5;

                            Console.Write("Operation is processed! Now, there are ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(freshCoffee);
                            Console.ResetColor();
                            Console.WriteLine(" fresh cups of coffee.");

                            Console.Write("The remaining number of shots of coffee to brew is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(availableCoffeeShots);
                            Console.ResetColor();
                            Console.WriteLine(".");
                        }
                        break;

                    case 3:
                        if (freshCoffee == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There is no fresh cup of coffee to sell. Please brew coffee or change your selection.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Please enter the number of cups to sell:");
                            Console.Write("Choice: ");
                            amount = Convert.ToInt32(Console.ReadLine());

                            while (amount <= 0 || amount > freshCoffee)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                if (amount <= 0)
                                {
                                    Console.WriteLine("Warning: The number of cups must be greater than zero. Please re-enter:");
                                }
                                else
                                {
                                    Console.Write("Warning: There are only ");
                                    Console.Write(freshCoffee);
                                    Console.WriteLine(" fresh cups of coffee to sell. Please re-enter the number of cups to sell:");
                                }

                                Console.ResetColor();
                                Console.Write("Choice: ");
                                amount = Convert.ToInt32(Console.ReadLine());
                            }

                            dailyOrders = dailyOrders + 1;
                            Console.Write("Operation is processed! The current number of orders is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(dailyOrders);
                            Console.ResetColor();
                            Console.WriteLine(".");

                            for (int i = 0; i < amount; i++)
                            {
                                Console.WriteLine("Sold 1 cup of coffee.");
                            }

                            freshCoffee = freshCoffee - amount;
                            money = money + (amount * 2);

                            Console.Write("Operation is processed! The remaining fresh cups of coffee are ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(freshCoffee);
                            Console.ResetColor();
                            Console.WriteLine(".");

                            Console.Write("The remaining number of shots of coffee to brew is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(availableCoffeeShots);
                            Console.ResetColor();
                            Console.WriteLine(".");

                            if (dailyOrders == 6)
                            {
                                Console.WriteLine("The maximum number of orders is reached!");
                                endDay = true;
                            }
                        }
                        break;

                    case 4:
                        if (money < 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: Insufficient balance to buy a croissant package!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Operation is processed! Please enter the number of packages to buy:");
                            Console.Write("Choice: ");
                            amount = Convert.ToInt32(Console.ReadLine());

                            while (amount <= 0 || amount > money / 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                if (amount <= 0)
                                {
                                    Console.WriteLine("Warning: The number of packages must be greater than zero. Please re-enter:");
                                }
                                else
                                {
                                    Console.WriteLine("Warning: Insufficient balance! Please re-enter the number of packages to buy:");
                                }

                                Console.ResetColor();
                                Console.Write("Choice: ");
                                amount = Convert.ToInt32(Console.ReadLine());
                            }

                            money = money - (amount * 10);
                            croissantBoxes = croissantBoxes + amount;

                            Console.Write("Operation is processed! There are currently ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(croissantBoxes);
                            Console.ResetColor();
                            Console.WriteLine(" packages of croissants to sell.");
                        }
                        break;

                    case 5:
                        if (croissantBoxes == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: You have no packages of croissants to open!");
                            Console.ResetColor();
                        }
                        else
                        {
                            croissantBoxes = croissantBoxes - 1;
                            croissantsReady = croissantsReady + 5;

                            Console.Write("Operation is processed! There are ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(croissantsReady);
                            Console.ResetColor();
                            Console.WriteLine(" croissants on the tray.");

                            Console.Write("The remaining number of packages of croissants to sell is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(croissantBoxes);
                            Console.ResetColor();
                            Console.WriteLine(".");
                        }
                        break;

                    case 6:
                        if (croissantsReady == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: There are no croissants on the tray to sell!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Please enter the number of croissants to sell:");
                            Console.Write("Choice: ");
                            amount = Convert.ToInt32(Console.ReadLine());

                            while (amount <= 0 || amount > croissantsReady)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                if (amount <= 0)
                                {
                                    Console.WriteLine("Warning: The number of croissants must be greater than zero. Please re-enter:");
                                }
                                else
                                {
                                    Console.Write("Warning: There are only ");
                                    Console.Write(croissantsReady);
                                    Console.WriteLine(" croissants on the tray to sell. Please re-enter the number of croissants to sell:");
                                }

                                Console.ResetColor();
                                Console.Write("Choice: ");
                                amount = Convert.ToInt32(Console.ReadLine());
                            }

                            dailyOrders = dailyOrders + 1;
                            Console.Write("Operation is processed! The current number of orders is ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(dailyOrders);
                            Console.ResetColor();
                            Console.WriteLine(".");

                            for (int i = 0; i < amount; i++)
                            {
                                Console.WriteLine("Sold 1 croissant.");
                            }

                            croissantsReady = croissantsReady - amount;
                            money = money + (amount * 3);

                            Console.Write("Operation is processed! There are currently ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(croissantsReady);
                            Console.ResetColor();
                            Console.WriteLine(" croissants on the tray.");

                            if (dailyOrders == 6)
                            {
                                Console.WriteLine("The maximum number of orders is reached!");
                                endDay = true;
                            }
                        }
                        break;

                    case 7:
                        if (dailyOrders < 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: The \"End of the Day >\" will not be functional before 3 (worked) orders in a day.");
                            Console.ResetColor();
                        }
                        else
                        {
                            endDay = true;
                        }
                        break;

                    case 8:
                        Console.Write("The final capital is ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(money + "Z");
                        Console.ResetColor();
                        Console.WriteLine(".");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Thank you for choosing us. We look forward to seeing you again!!!");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------------------------------------------------------------------------");

                        isGameRunning = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: Invalid choice. Please select an option from 1 to 8.");
                        Console.ResetColor();
                        break;
                }

                // End-of-day operations
                if (endDay)
                {
                    Console.WriteLine("It is the end of the day!");

                    int remainingCoffeePackages = availableCoffeeShots / 3;

                    Console.Write("The current budget is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(money + "Z");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.Write("The remaining number of full packages of coffee is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(remainingCoffeePackages);
                    Console.ResetColor();

                    Console.Write("The remaining number of shots of coffee is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(availableCoffeeShots);
                    Console.ResetColor();

                    Console.Write("The remaining number of packages of croissants is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(croissantBoxes);
                    Console.ResetColor();

                    // Fresh coffee becomes stale every day.
                    freshCoffee = 0;

                    // The croissant tray is cleaned every two days.
                    if (currentDay % 2 == 0)
                    {
                        croissantsReady = 0;
                    }

                    Console.Write("The remaining number of croissants on the tray is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(croissantsReady);
                    Console.ResetColor();

                    currentDay = currentDay + 1;
                    dailyOrders = 0;
                }

                firstTime = false;
            }
        }
    }
}
