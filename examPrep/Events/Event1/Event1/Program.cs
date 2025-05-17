namespace Event1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            button.Clicked += OnButtonClicked;
            button.Clicked += (object? sender, EventArgs e) => 
                Console.WriteLine("Did it again from Lambda...");

            button.Click();
        }

        static void OnButtonClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("Someone clicked the button!");
        }
    }
}
