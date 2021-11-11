using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleHouse.Model
{
    public partial class House
    {
        public string GetHouseComplex
        {
            get
            {
                string complex = HouseComplex.Name + " | " + Street.Name + " | " + HouseComplex.BuildStatus.Name;
                return complex;
            }
        }

        public string GetHouse
        {
            get
            {
                int amountSale = Context._con.Apartment.Where(p => p.SaleStatusId == 1).Count();
                int amontReady = Context._con.Apartment.Where(p => p.SaleStatusId == 2).Count(); 
                string house = Number + " | Продано: " + amountSale + " | Готово к продаже: " + amontReady;
                return house;
            }
        }
    }
}
