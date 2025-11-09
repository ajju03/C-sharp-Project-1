//Initialisation of the random number aand the points.
            int playerRandomNumber;
            int systemRandomNumber;
            Random random = new Random();
            bool tryAgain = false;
            //Welcome message to the user.

            do
            {
                int playerPoint = 0;
                int systemPoint = 0;
                Console.WriteLine("Welcome to the  DIE ROLLER game");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("please wait your game is loading.......");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Game Description : \n* You have to press enter to roll.\n* The system will roll afterwards.\n* If the system gets number lesser than you , you got a point.\n* You got 3 rounds.\n* you've to win atleast 2 rounds to win the entire game!!");
                //Loop to iterate the random number.
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Press enter key to roll -> ");
                    Console.ReadKey();
                    playerRandomNumber = random.Next(1, 7);
                    Console.WriteLine($"You got {playerRandomNumber}.");
                    systemRandomNumber = random.Next(1, 7);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"System got {systemRandomNumber}");
                    if (playerRandomNumber > systemRandomNumber)
                    {
                        Console.WriteLine("You won this round.");
                        playerPoint++;
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (playerRandomNumber < systemRandomNumber)
                    {
                        Console.WriteLine("You have lost this round.");
                        systemPoint++;
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("You have a tie.");
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.WriteLine($"Your current point is {playerPoint}.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"System's point is {systemPoint}");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                    if (playerPoint != 0)
                    {
                        if (playerPoint > systemPoint)
                        {
                            if (playerPoint % 2 == 0)
                            {
                                Console.WriteLine("You win!!");
                                break;
                            }
                        }
                    }
                    if(systemPoint != 0)
                    {
                        if(systemPoint % 2 == 0)
                        {
                            Console.WriteLine("Sorry you've lost this game.");
                            break;
                        }
                    }
                }
                if (playerPoint == systemPoint)
                {
                    Console.WriteLine("The match is draw.");
                }
                Console.WriteLine();
                Console.WriteLine("Wanna retry ?\n--Press r and then press enter to retry. \n--Press enter to exit.");
                string opt = Console.ReadLine();
                if (opt == "r")
                {
                    tryAgain = true;
                }
                else
                {
                    break;
                }

            } while (tryAgain);
