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

namespace UpravFin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public bool LogAdm;
        public Avtoriz()
        {
            InitializeComponent();

        }
        

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var userObj = FinAdo.entObj.User.FirstOrDefault(x =>
                x.Login == TxbLogin.Text && x.Password == Pas.Password);

                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет", "Ошибка Авторизации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                    NavigationService.Navigate(new Reg());
                }
                else
                {
                    switch (userObj.IDRole)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте администратор, " + userObj.Login + " !", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                            // NavigationService.Navigate (new PageAdm());
                            LogAdm = true;
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте, " + userObj.Login + " !", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                            // NavigationService.Navigate(new PageClient());
                            LogAdm = false;
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены", "Уведомление",
                   MessageBoxButton.OK, MessageBoxImage.Warning);
                            NavigationService.Navigate(new Reg());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message.ToString(), "Критическая работа приложения",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reg());
        }

        private void Button_Nazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
