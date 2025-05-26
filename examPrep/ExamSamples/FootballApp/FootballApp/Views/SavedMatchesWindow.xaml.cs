using FootballApp.Context;
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

            try
            {
                using (var db = new MatchContext())
                {
                    var matches = db.Matches.ToList();
                    MatchesGrid.ItemsSource = matches;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while retreiving data:\n{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
