using MauiMvvmProject.Models;
using MauiMvvmProject.ViewModels;

namespace MauiMvvmProject.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item;
		var employeeDetailViewModel2 = new EmployeeDetailsViewModel2 { Employee = employee };
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeDetailViewModel2;

		Navigation.PushAsync(employeeDetailPage);
    }
}