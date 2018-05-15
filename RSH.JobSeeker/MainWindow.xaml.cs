using DataLayer.Tools.Infrastructure;
using Models;
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

namespace RSH.JobSeeker
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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    UnitOfWork un = new UnitOfWork();
        //    Person p = new Person()
        //    {
        //        Email = "d",
        //        FirstName = "Reza",
        //        LastName = "Shazari",
        //        EmergancyPhone = "0",
        //        Mobile = "09351986600",
        //        Password= "159951159951",
        //        ResumeUrl = "/"
        //    };
        //    un.PersonRepository.Insert(p);
        //    un.Save();
        //    MessageBox.Show(un.PersonRepository.Get().ToString());
        //}

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnOpenMenu.Visibility = Visibility.Visible;
            BtnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void BtnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnCloseMenu.Visibility = Visibility.Visible;
            BtnOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuInformation.StaysOpen = true;
        }

        private void ShowCompanyBtn_Click(object sender, RoutedEventArgs e)
        {
            CompanyWindow companyWindow = new CompanyWindow();
            companyWindow.ShowDialog();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
