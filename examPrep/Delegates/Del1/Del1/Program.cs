namespace Del1
{
    public delegate void PrintMessage(string message); // Delegate

    internal class Program
    {
        static void Main()
        {
            PrintMessage printer = PrintToConsole;
            printer("Hello, Delegates!"); // Method Call

            printer += PrintToFile;
            printer("This goes to console and file!");

            printer += PrintAgain;
            printer("Damn that is cool...");

            printer += (string msg) => Console.WriteLine($"Anonymous function: {msg}");
            printer("Hello from Lambda!");

            // printer -= PrintToConsole;
            // printer -= PrintToFile;
            // printer -= PrintAgain;
        }

        public static void PrintToConsole(string msg) => 
            Console.WriteLine($"Console: {msg}");

        public static void PrintToFile(string msg) => 
            File.WriteAllText("output.txt", $"File: {msg}");

        public static void PrintAgain(string msg) =>
            Console.WriteLine($"Again: {msg}");
    }
}
