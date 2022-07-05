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
    /// Interaction logic for AirlinesAutoSysForUser.xaml
    /// </summary>
    public partial class AirlinesAutoSysForUser : Window
    {
        public AirlinesAutoSysForUser()
        {
            InitializeComponent();
            MainFrame.Navigate(new ExitPage());
            Manager.MainFrame = MainFrame;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ReasonExit reasonExit = new ReasonExit();
            reasonExit.Show();
            this.Close();
        }
    }
}
