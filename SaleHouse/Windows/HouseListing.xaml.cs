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
using SaleHouse.Model;

namespace SaleHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для HouseListing.xaml
    /// </summary>
    public partial class HouseListing : Window
    {
        List<House> houses = new List<House>();

        public HouseListing()
        {

            InitializeComponent();
            HouseList.ItemsSource = Context._con.House.ToList();
            HouseComplexCB.ItemsSource = Context._con.HouseComplex.ToList();
            AddressCB.ItemsSource = Context._con.Street.ToList();
            
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HouseComplexCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void AddressCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        public void Filter() // Плохая фильтрация, но тоже сойдёт
        {
            houses = Context._con.House.ToList();
            if (AddressCB.SelectedIndex >= 0)
            {
                houses = houses.Where(p => p.StreetId == AddressCB.SelectedIndex + 1).ToList();
            }
            HouseList.ItemsSource = houses;

            if (HouseComplexCB.SelectedIndex >= 0)
            {
                houses = houses.Where(p => p.HouseComplexId == HouseComplexCB.SelectedIndex + 1).ToList();
            }
            HouseList.ItemsSource = houses;
        }

        private void DeleteHouse(object sender, RoutedEventArgs e)
        {
            ShowMessage.InfMesssage("Окно в разработке!");
        }
    }
}
