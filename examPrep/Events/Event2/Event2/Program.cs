namespace Event2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.ProcessCompleted += ProcessCompletedHandler;
            process.Start();
            process.ProcessCompleted -= ProcessCompletedHandler;

            process.ProcessCompleted += Another;
            process.Start();
        }

        static void ProcessCompletedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Event received: Process completed!");
        }

        static void Another(object sender, EventArgs e)
        {
            Console.WriteLine("Testing some crazy stuff...");
        }
    }
}
