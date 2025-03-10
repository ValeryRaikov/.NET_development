using MauiMvvmProject.ViewModels;

namespace MauiMvvmProject.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void employeeBtn1_Clicked(object sender, EventArgs e)
    {
        // var employeeDetailViewModel = new EmployeeDetailsViewModel
        // {
        //     EmployeeId = "1001",
        //     Name = "Ivan",
        //     Email = "ivan@gmail.com",
        //     IsPartTimer = false,
        // };
        // 
        // var employeeDetailPage = new EmployeeDetailPage();
        // employeeDetailPage.BindingContext = employeeDetailViewModel;
        // 
        // Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeBtn2_Clicked(object sender, EventArgs e)
    {
        // var employeeDetailViewModel = new EmployeeDetailsViewModel
        // {
        //     EmployeeId = "1002",
        //     Name = "Maria",
        //     Email = "maria@gmail.com",
        //     IsPartTimer = true,
        // };
        // 
        // var employeeDetailPage = new EmployeeDetailPage();
        // employeeDetailPage.BindingContext = employeeDetailViewModel;
        // 
        // Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeBtn3_Clicked(object sender, EventArgs e)
    {
        // var employeeDetailViewModel = new EmployeeDetailsViewModel
        // {
        //     EmployeeId = "1003",
        //     Name = "Stamat",
        //     Email = "stamat@gmail.com",
        //     IsPartTimer = false,
        // };
        // 
        // var employeeDetailPage = new EmployeeDetailPage();
        // employeeDetailPage.BindingContext = employeeDetailViewModel;
        // 
        // Navigation.PushAsync(employeeDetailPage);
    }
}