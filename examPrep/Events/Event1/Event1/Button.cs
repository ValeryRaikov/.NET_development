namespace Event1
{
    internal class Button
    {
        public event EventHandler? Clicked;

        public void Click()
        {
            Console.WriteLine("Button was clicked!");
            Clicked?.Invoke(this, EventArgs.Empty); 
        }
    }
}
