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
    /// Логика взаимодействия для ImageEdit.xaml
    /// </summary>
    public partial class ImageEdit : Page
    {
        Service service;
        public ImageEdit(Service service)
        {
            InitializeComponent();
            this.service = service;
            tbNameService.Text = "Дополнительные изображения к услуге " + service.Title;
            lvImage.ItemsSource = Model.tbe.ServicePhoto.Where(x => x.ServiceID == service.ID).ToList();

        }

        private void btnDeleteImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddPicture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfServices(true));
        }
    }
}
