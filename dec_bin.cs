using System;

class Part2
{

    public static int binToDec(string bin_string) {

        int length = bin_string.Length;
        double dec_value = 0;
        int count = 0;
        double exponent = 0;
        double num_val = 0;
        for (int i = length-1; i >= 0; i--)
        {
            exponent = Math.Pow(2, i);
            num_val = Char.GetNumericValue(bin_string[count]);
            dec_value += num_val * exponent;
            count++;
        }

        return (int)dec_value;   
    }
    public static string decToBin(int number) {
        
        string bin = "";

        Console.Write($"\n{number} "); //the start of the console statement
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                bin = "0" + bin;
            }
            else
            {
                bin = "1" + bin;
            }

            number /= 2;
        }

        return bin;
    }
    static void Main()
    {
        Console.WriteLine("Welcome!");
        int _decimal;
        string _binary;

        Console.WriteLine("Pick an option, please: \n1 - Decimal to binary\n2 - Binary to Decimal\nPress any other character to quit");
        char choice = Char.Parse(Console.ReadLine());


        while (choice == '1' || choice == '2')
        {
            if (choice == '1')
            {
                Console.WriteLine("Enter an interger to convert to binary: ");
                _decimal = Int32.Parse(Console.ReadLine());
                Console.Write($"{_decimal} converted to binary is {decToBin(_decimal)}");
            }
            if (choice == '2')
            {
                Console.WriteLine("Enter a binary number to convert to an interger: ");
                _binary = Console.ReadLine();
                Console.Write($"{_binary} converted to binary is {binToDec(_binary)}");
            }


            Console.WriteLine("\n\n_______________________\n\nWelcome back! :D\nPick an option, please: \n1 - Decimal to binary\n2 - Binary to Decimal\nPress any other character to quit");
            choice = Char.Parse(Console.ReadLine());
        } 

        Console.WriteLine("Goodbye!");
    }
}
