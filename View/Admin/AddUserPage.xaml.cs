using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaundryApps.View.Admin
{
    /// <summary>
    /// Interaction logic for AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        Controller.AddUserController add;
        public AddUserPage()
        {
            InitializeComponent();
            add = new Controller.AddUserController(this);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (add.regist()) NavigationService.Navigate(new View.Admin.UsersListPage());
        }
    }
}
