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
    /// Interaction logic for InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();

            var allOffices = Session1_XXEntities.GetContext().Offices.ToList();

            allOffices.Insert(0, new Offices
            {
                Title = "All Offices"
            });

            SelectOffice.ItemsSource = allOffices;

            //DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Users user = DGridUser.SelectedItem as Users;
            if (user.RoleID == 1)
            {
                user.RoleID = 2;
            }
            else
            {
                user.RoleID = 1;
            }
            try
            {
                Session1_XXEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Session1_XXEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
        }

        private void SelectOffice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SelectOffice.SelectedIndex)
            {
                case 0:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
                    break;
                case 1:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.Where(p => p.OfficeID == 1).ToList();
                    break;
                case 2:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.Where(p => p.OfficeID == 3).ToList();
                    break;
                case 3:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.Where(p => p.OfficeID == 4).ToList();
                    break;
                case 4:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.Where(p => p.OfficeID == 5).ToList();
                    break;
                case 5:
                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.Where(p => p.OfficeID == 6).ToList();
                    break;
            }
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            Session1_XXEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
        }

        private void Disable_Click(object sender, RoutedEventArgs e)
        {
            var userForDisable = DGridUser.SelectedItems.Cast<Users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {userForDisable.Count()} элементов?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Session1_XXEntities.GetContext().Users.RemoveRange(userForDisable);
                    Session1_XXEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridUser.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
