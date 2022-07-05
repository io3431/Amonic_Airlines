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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amonic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public static class Global
        {
            public static Users getuser { get; set; }
            public static String gettime;
            public static DateTime getdatetime;
            public static DateTime date;
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            using (var db = new Session1_XXEntities())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Email == textBoxLogin.Text && u.Password == textBoxPassword.Password);
                var logi = db.Users.AsNoTracking().FirstOrDefault(u => u.Email == textBoxLogin.Text);
                Global.getuser = user;

                if (logi == null)
                {
                    errors.AppendLine("Пользователь не найден");
                }
                if (user == null)
                {
                    errors.AppendLine("Неверный пароль");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (errors.Length == 0)
                {
                    if (user.RoleID == 1)
                    {
                        AirlinesAutoSys airlines = new AirlinesAutoSys();
                        airlines.WindowState = WindowState.Maximized;
                        airlines.Show();
                        this.Close();
                    }
                    if (user.RoleID == 2)
                    {
                        AirlinesAutoSysForUser airlinesForUser = new AirlinesAutoSysForUser();
                        airlinesForUser.WindowState = WindowState.Maximized;
                        airlinesForUser.Show();
                        Global.date = DateTime.Now; 
                        this.Close();
                    } 
                }
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
