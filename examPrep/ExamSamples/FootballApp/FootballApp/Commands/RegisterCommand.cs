using FootballApp.Commands;
using FootballApp.Context;
using FootballApp.Models;

public class RegisterCommand : BaseCommand
{
    private LoginVM _viewModel;

    public RegisterCommand(LoginVM vm)
    {
        _viewModel = vm;
    }

    public override void Execute(object? parameter)
    {
        try
        {
            using (var db = new DatabaseContext())
            {
                if (string.IsNullOrWhiteSpace(_viewModel.Username) || string.IsNullOrWhiteSpace(_viewModel.Password))
                {
                    _viewModel.Message = "Username and password are required.";
                    return;
                }

                if (db.Users.Any(u => u.Username == _viewModel.Username))
                {
                    _viewModel.Message = "Username already exists.";
                    return;
                }

                db.Users.Add(new User { Username = _viewModel.Username, Password = _viewModel.Password });
                db.SaveChanges();
                _viewModel.Message = "User registered successfully. You can now log in.";
            }
        }
        catch (Exception ex)
        {
            // Add UI feedback
        }
    }
}
