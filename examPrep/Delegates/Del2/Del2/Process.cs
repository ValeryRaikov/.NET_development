namespace Del2
{
    public delegate void Notify();

    public class Process
    {
        public Notify? OnProcessCompleted;

        public void Start()
        {
            Console.WriteLine("Processing...");
            Thread.Sleep(1000);

            OnProcessCompleted?.Invoke();
        }
    }

}
