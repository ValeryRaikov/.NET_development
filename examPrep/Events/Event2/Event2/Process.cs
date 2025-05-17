namespace Event2
{
    public class Process
    {
        public event EventHandler? ProcessCompleted; 

        public void Start()
        {
            Console.WriteLine("Processing...");
            Thread.Sleep(1000);
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
