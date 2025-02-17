using System;
using Project_Valeri.Model;
using Project_Valeri.Others;
using Project_Valeri.ViewModel;
using Project_Valeri.View;

namespace Project_Valeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Valery", "Valercho123$", UserRolesEnum.STUDENT, "vraykov@tu-sofia.bg");
            UserViewModel uvm = new UserViewModel(u);
            UserView uv = new UserView(uvm);

            uv.Display();
            uv.DisplayHashedPassword();

            Console.ReadKey();
        }
    }
}
