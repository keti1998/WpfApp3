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
using System.ServiceProcess;

namespace WpfApp3
{
  //  ServiceController[] services = ServiceController.GetServices();
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceController[] services = ServiceController.GetServices();
      //  List <Services> _services;
        public MainWindow()
        {
            InitializeComponent();

            //ServiceController[] services = ServiceController.GetServices();
            dataGrid.ItemsSource = services;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ServiceController[] services = ServiceController.GetServices();


            foreach (ServiceController service in services)
            {
                MessageBox.Show(service.ServiceName);
            }


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
