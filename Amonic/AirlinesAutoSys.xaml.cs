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

namespace Amonic
{
    /// <summary>
    /// Interaction logic for AirlinesAutoSys.xaml
    /// </summary>
    public partial class AirlinesAutoSys : Window
    {
        public AirlinesAutoSys()
        {
            InitializeComponent();
            MainFrame.Navigate(new InfoPage());
            Manager.MainFrame = MainFrame;
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUser add = new AddUser(null);
            add.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add.Show();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
