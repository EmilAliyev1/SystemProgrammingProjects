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

        string filePath = args[0];
        string searchWord = args[1];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string text = File.ReadAllText(args[0]);
        int count = text.Split(args[1]).Length - 1;

        Console.WriteLine($"\"{args[1]}\" appears {count} times.");

        #endregion
        
    }
}