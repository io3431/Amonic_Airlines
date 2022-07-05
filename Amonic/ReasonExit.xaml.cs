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
    /// Interaction logic for ReasonExit.xaml
    /// </summary>
    public partial class ReasonExit : Window
    {
        public ReasonExit()
        {
            InitializeComponent();

            infoUserSpentInSystem.Text = $"{MainWindow.Global.getuser.FirstName} you spent {MainWindow.Global.gettime} in the system.";
            infoUserDate.Text = $"Date: {DateTime.Now.ToString("d")}";

            TimeSpan timeLogin = DateTime.Now - MainWindow.Global.getdatetime;
            //TimeSpan timeLoginOfSys = new TimeSpan(timeLogin.Hours/timeLogin.Minutes/timeLogin.Seconds);
            infoUserLogin.Text = $"Login: {timeLogin.Hours}:{timeLogin.Minutes}:{timeLogin.Seconds}";
            infoUserLogout.Text = $"Logout: {DateTime.Now.ToString("T")}";
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            Logout logout = new Logout();
            logout.LoginTime = MainWindow.Global.date;
            logout.LogoutTime = DateTime.Now;
            logout.Date = DateTime.Now;
            logout.Time = MainWindow.Global.gettime;
            logout.Reason = BoxReason.Text;
            logout.UserID = MainWindow.Global.getuser.ID;
            Session1_XXEntities.GetContext().Logout.Add(logout);
            try
            {
                Session1_XXEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }
    }
}
