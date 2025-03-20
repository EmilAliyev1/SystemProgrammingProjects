class Program{
    static void Main(string[] args)
    {
        #region Task3

        // if (args.Length != 3)
        // {
        //     Console.WriteLine("Incorrect amount of args");
        //     return;
        // }

        // if (!double.TryParse(args[0], out double num1) || !double.TryParse(args[1], out double num2))
        // {
        //     Console.WriteLine("Invalid numbers provided.");
        //     return;
        // }

        // string operation = args[2];

        // double result = operation switch
        // {
        //     "+" => num1 + num2,
        //     "-" => num1 - num2,
        //     "*" => num1 * num2,
        //     "/" => num1 / num2
        // };

        // Console.WriteLine($"{num1} {operation} {num2} = {result}");

        #endregion

        #region Task4

        if (args.Length != 2){
            Console.WriteLine("Incorrect amount of args");
        }

        #endregion
        
    }
}