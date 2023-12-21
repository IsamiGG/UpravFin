using Microsoft.Win32;
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
    /// Логика взаимодействия для Sotr.xaml
    /// </summary>
    public partial class Sotr : Page
    {
        private Personal PersonalObj = new Personal();
        
        public Sotr(Personal selectedPersonal)
        {
            InitializeComponent();
            if (selectedPersonal != null)
                PersonalObj = selectedPersonal;

            DataContext = PersonalObj;          
        }
                private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
              {
                  FinAdo.entObj.Personal.Add(PersonalObj);
                  FinAdo.entObj.SaveChanges();
                 
                  MessageBox.Show("Результат добавлен в базу данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбой работы приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
              }

           

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg,*.jpeg;*.png;*.tif|All files|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == true)
            {
                Uri imageUri = new
                    Uri(openFileDialog.FileName);
                kartinka.Source = new BitmapImage(imageUri);
            }
         
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                FinAdo.entObj.SaveChanges();

                MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбой работы приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void TxbLogin_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
