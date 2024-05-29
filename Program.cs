using System.Diagnostics;

internal class Program
{
    
    private static void Main(string[] args)
    {
        if ((args.Length != 3)){
            Console.WriteLine("Введено неверное количество параметров");
            return;}

        if (!(Double.TryParse(args[0],out double firstNum) && Double.TryParse(args[2], out double secondNum))){
            Console.WriteLine("Один из аргументов введен некорректно");
            return;}

        double res = 0;
        switch (args[1])
        {
            case "+":
                res = firstNum + secondNum;
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} = {Double.Round(res,2)}");
                return;
            case "-":
                res = firstNum - secondNum;
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} = {Double.Round(res,2)}");
                return;
            case "/":
                res = firstNum / secondNum;
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} = {Double.Round(res,2)}");
                return;
            case "*":
                res = firstNum * secondNum;
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} = {Double.Round(res, 2)}");
                return;

            default:
                Console.WriteLine("Что-то пошло не так...");
                return;
        }
    }
}