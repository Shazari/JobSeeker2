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
using System.Windows.Shapes;

namespace RSH.JobSeeker
{
    /// <summary>
    /// Interaction logic for CompanyWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {
        public CompanyWindow()
        {
            InitializeComponent();
        }

        UnitOfWork oUnitOfWork = new UnitOfWork();

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

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Company oCompany = new Company() {
                CompanyName = txtCompanyName.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                Tel = txtTel.Text,
                Other = txtOther.Text
            };
            oUnitOfWork.CompanyRepository.Insert(oCompany);
            oUnitOfWork.Save();
        }

        private void CompanyWindow1_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
