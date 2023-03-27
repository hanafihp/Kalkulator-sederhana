using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char op;

        Console.WriteLine("Kalkulator Sederhana\n");

        Console.Write("Masukkan angka pertama: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                break;
            case '/':
                result = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                break;
            default:
                Console.WriteLine("Operator yang dimasukkan salah.");
                break;
        }

        Console.ReadKey();
    }
}