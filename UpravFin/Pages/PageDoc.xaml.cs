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
    /// Логика взаимодействия для PageDoc.xaml
    /// </summary>
    public partial class PageDoc : Page
    {
        public PageDoc()
        {
            InitializeComponent();
        }
        public string txt;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Doc DocObj = new Doc()
                {
                    Vid = Vidd.Text,
                    Number = Convert.ToInt32(TxbLogin_Copy1.Text),
                    Date = Convert.ToDateTime(data.Text),
                    Name = TxbLogin_Copy.Text,
                    FileDoc = txt,
                };

                FinAdo.entObj.Doc.Add(DocObj);
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
            openFileDialog.Filter = "Document files|*.doc;*.docx,*.pdf;*.txt;|All files|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == true)
            {
               txt=openFileDialog.FileName;
               
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
