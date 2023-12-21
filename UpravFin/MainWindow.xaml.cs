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
using UpravFin.Pages;

namespace UpravFin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();

           FrameApp.frameObj = FrmMain;
           FrmMain.Navigate(new Info());
           FinAdo.entObj = new UpravFinEntities2();
          
    }
        public bool LogAdm;

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new AnalizFinSpisok());
        }

       
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new SpisokSotr());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Budjet()); 
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new DocSpisok());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new TelSpravSpisok());
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Avtoriz());
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
