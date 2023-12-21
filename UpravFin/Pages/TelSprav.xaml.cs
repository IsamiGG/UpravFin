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
    /// Логика взаимодействия для TelSprav.xaml
    /// </summary>
    public partial class TelSprav : Page
    {
        public TelSprav()
        {
            InitializeComponent();
        }

       

        
        

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Spravochnik SpravochnikObj = new Spravochnik()
                {
                    FIO =TxbLogin12.Text,
                    IDJobTittle = Convert.ToInt32(Job12.Text),
                    Nkabineta = Convert.ToInt32(TxbLogin_Copy1.Text),
                    Telephone = TxbLogin_Copy3.Text,
                    
                };

                FinAdo.entObj.Spravochnik.Add(SpravochnikObj);
                FinAdo.entObj.SaveChanges();

                MessageBox.Show("Результат добавлен в базу данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбой работы приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
