using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            PawnShopContext context = new PawnShopContext();
            context.Database.Initialize(true);
        }
    }
}
