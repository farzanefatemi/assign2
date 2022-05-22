using System;
public class Session1
{
    public static void Main(string[] args)
    {

        for (int rows = 1; rows <= 5; rows++)
        {
            for (int spaces = 1; spaces <= 5 - rows; spaces++)
            {
                Console.Write(" ");
            }
            for (int numbers = 1; numbers <= rows; numbers++)
            {
                Console.Write(numbers);
            }
            for (int num = rows - 1; num >= 1; num--)
            {
                Console.Write(num);
            }
            Console.Write("\n");
        }
    }
}

