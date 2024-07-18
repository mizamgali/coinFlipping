using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int countCross;
        int countPiles;

        Console.WriteLine("WELCOME!");
        Console.WriteLine ("How much to drop? ");

        int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {                     
                int randomNum =  random.Next(2);

                if(randomNum == 0){
                    Console.WriteLine("Cross!");
                    countCross++;
                    
                }else{
                    Console.WriteLine("Pile!");
                    countPiles++;
                }             
            }
            Console.WriteLine("Crosses: " + CountCross);
            Console.WriteLine("Piles: " + CountPiles);
    }
}