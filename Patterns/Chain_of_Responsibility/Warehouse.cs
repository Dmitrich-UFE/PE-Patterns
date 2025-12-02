using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Warehouse
    {
        List<Good> Goods;

        internal Warehouse(params Good[] goods) 
        {
            Goods = new List<Good>();
            foreach (var good in goods) 
            {
                Goods.Add(good);
            }
        }

        internal bool FindInWareHouse(Good good) 
        {
            return Goods.Find(WHGood => (WHGood.Name == good.Name) && (WHGood.Price == good.Price)) != null ? true: false;
        }
    }
}
