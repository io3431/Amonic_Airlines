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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private Users _currentUser = new Users();

        public AddUser(Users selectedUser)
        {
            if (selectedUser != null)
            {
                _currentUser = selectedUser;
            }

            InitializeComponent();


            DataContext = _currentUser;
            ComboOffice.ItemsSource = Session1_XXEntities.GetContext().Offices.ToList();
            ComboRoles.ItemsSource = Session1_XXEntities.GetContext().Roles.ToList();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.Email))
            {
                errors.AppendLine("Укажите Email");
            }
            if (string.IsNullOrWhiteSpace(_currentUser.FirstName))
            {
                errors.AppendLine("Укажите Имя");
            }
            if (string.IsNullOrWhiteSpace(_currentUser.LastName))
            {
                errors.AppendLine("Укажите Фаимлию");
            }
            if (_currentUser.Offices == null)
            {
                errors.AppendLine("Укажите Офис");
            }
            if (_currentUser.Birthdate == null)
            {
                errors.AppendLine("Укажите Дату Рождения");
            }
            if (string.IsNullOrWhiteSpace(_currentUser.Password))
            {
                errors.AppendLine("Укажите Пароль");
            }
            if (_currentUser.Roles == null)
            {
                errors.AppendLine("Укажите Роль");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentUser.ID == 0)
            {
                Session1_XXEntities.GetContext().Users.Add(_currentUser);
            }

            try
            {
                Session1_XXEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
