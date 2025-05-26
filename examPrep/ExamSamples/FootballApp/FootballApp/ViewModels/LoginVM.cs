using System.ComponentModel;
using System.Windows.Input;

public class LoginVM : INotifyPropertyChanged
{
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Message { get; set; } = "";

    public ICommand LoginCommand { get; }
    public ICommand RegisterCommand { get; }

    public LoginVM()
    {
        LoginCommand = new LoginCommand(this);
        RegisterCommand = new RegisterCommand(this);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
