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

namespace LanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientRecordService.xaml
    /// </summary>
    public partial class ClientRecordService : Page
    {
        Service service;
        public ClientRecordService(Service service)
        {
            InitializeComponent();
            this.service = service;
            tbTitle.Text = "Услуга " + service.Title;
            tbTime.Text = "Длительность услуги " + service.Duration + " минут";

            cmbClient.ItemsSource = Model.tbe.Client.ToList();
            cmbClient.SelectedValuePath = "ID";
            cmbClient.DisplayMemberPath = "allClient";
        
           
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfServices(true));
        }

        private void btnAddClien_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
