using System;


    class StatementIfElse
    {
        public void ageCheck(int x)
        {
            if (x > 18)
            {
                Console.WriteLine("you are greater than 18");
            }
            else
            {
                Console.WriteLine("you are less than 18");
            }
        }
        public void days(int day)
        {
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        }  
    
        public void for_loop()
        {
          for(int i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
        }
  
        public void while_loop()
        {

        int i = 0;
            while (i <=5)
                {
                    Console.WriteLine("loop " + i);
                    i++;
                }
        }
    }

