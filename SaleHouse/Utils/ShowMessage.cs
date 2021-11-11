using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SaleHouse
{
    public static class ShowMessage
    {
        public static void InfMesssage(string message)
        {
            MessageBox.Show(message, "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
