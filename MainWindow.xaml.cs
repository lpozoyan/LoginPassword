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

namespace LoginPassword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AuthService authService = new AuthService();
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            try
            {
                bool valid = authService.IsValid(login, password);
                if (valid == true)
                {
                    Window1 loginPassed = new Window1();
                    loginPassed.Show();
                    this.Close();
                }
                else 
                { 
                    var mb = MessageBox.Show("Неверный логин или пароль", "ошибка", MessageBoxButton.YesNo);
                    if(mb == MessageBoxResult.No)
                   
                } 
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Сообщение",MessageBoxButton.YesNo, MessageBoxImage.Error);
            }
            
        }
    }
}
