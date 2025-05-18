namespace MauiMVVM1.Commands
{
    public class CopyColorCommand : BaseCommand
    {
        public override void Execute(object? parameter)
        {
            if (parameter is string hexCode)
            {
                Clipboard.SetTextAsync(hexCode);
            }
        }
    }
}
