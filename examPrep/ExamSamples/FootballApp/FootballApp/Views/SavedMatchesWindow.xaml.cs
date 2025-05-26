using FootballApp.Context;
using FootballApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FootballApp.Views
{
    /// <summary>
    /// Interaction logic for SavedMatchesWindow.xaml
    /// </summary>
    public partial class SavedMatchesWindow : Window
    {
        public SavedMatchesWindow()
        {
            InitializeComponent();
            DataContext = new SavedMatchesVM();
        }
    }
}
