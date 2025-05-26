using FootballApp.Commands;
using FootballApp.ViewModels;
using FootballApp;
using System.Windows;
using FootballApp.Context;

public class LoginCommand : BaseCommand
{
    private LoginVM _viewModel;

    public LoginCommand(LoginVM vm)
    {
        _viewModel = vm;
    }

    public override void Execute(object? parameter)
    {
        try
        {
            using (var db = new DatabaseContext())
            {
                var user = db.Users.FirstOrDefault(
                    u => u.Username == _viewModel.Username && u.Password == _viewModel.Password
                );

                if (user != null)
                {
                    var main = new MainWindow { DataContext = new MainWindowVM() };
                    foreach (Window w in Application.Current.Windows) w.Close();
                    main.Show();
                }
                else
                {
                    _viewModel.Message = "Invalid username or password.";
                }
            }
        }
        catch (Exception ex)
        {
            // Add UI feedback
        }
    }
}
