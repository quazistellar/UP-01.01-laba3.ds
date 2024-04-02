using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using UP_laba3.ds.UP_laba_1DataSetTableAdapters;

namespace UP_laba3.ds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     PilotsOfShipTableAdapter pilots = new PilotsOfShipTableAdapter();

        public MainWindow()
        {
            InitializeComponent();

            dgrid.ItemsSource = pilots.GetDataBy();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dgrid.Columns[0].Visibility = Visibility.Collapsed;
            dgrid.Columns[4].Visibility = Visibility.Collapsed;
            dgrid.Columns[5].Visibility = Visibility.Collapsed;
            dgrid.Columns[8].Visibility = Visibility.Collapsed;

            dgrid.Columns[1].Header = "Имя пилота";
            dgrid.Columns[2].Header = "Фамилия пилота";
            dgrid.Columns[3].Header = "Возраст";
            dgrid.Columns[6].Header = "Название корабля";
            dgrid.Columns[7].Header = "Количество полётов";
            dgrid.Columns[9].Header = "Тип корабля";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
