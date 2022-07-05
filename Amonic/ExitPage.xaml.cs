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
using System.Windows.Threading;

namespace Amonic
{
    /// <summary>
    /// Interaction logic for ExitPage.xaml
    /// </summary>
    public partial class ExitPage : Page
    {
        public ExitPage()
        {
            InitializeComponent();

            helloTextBlock.Text = $"Hello {MainWindow.Global.getuser.FirstName}. Welcome to AMONIC Airlines.";

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            DGridLogout.ItemsSource = Session1_XXEntities.GetContext().Logout.Where(p => p.UserID == MainWindow.Global.getuser.ID).ToList();
        }

        DateTime time = new DateTime(0, 0);

        private void timerTick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            timerBtn.Content = time.ToLongTimeString();
            MainWindow.Global.gettime = time.ToLongTimeString();
            MainWindow.Global.getdatetime = time;
        }
    }
}
