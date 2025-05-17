namespace Del2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.OnProcessCompleted = NotifyUser;
            process.Start();
        }

        static void NotifyUser()
        {
            Console.WriteLine("Process completed!");
        }
    }
}
