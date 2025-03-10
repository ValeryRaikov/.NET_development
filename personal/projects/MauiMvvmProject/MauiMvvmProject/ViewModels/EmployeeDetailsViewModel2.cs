using CommunityToolkit.Mvvm.ComponentModel;
using MauiMvvmProject.Models;

namespace MauiMvvmProject.ViewModels
{
    // Demonstration of simplified usage of CommunityToolkit Library
    public partial class EmployeeDetailsViewModel2 : ObservableObject
    {
        [ObservableProperty]
        private Employee _employee;
    }
}
