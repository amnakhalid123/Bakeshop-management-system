using ProjectDLL.DL.DB;
using ProjectDLL.DL.FH;
using ProjectDLL.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class ObjectHandler
    {
        private static IProductDL productDL = new ProductFH();

        public static IProductDL GetProductDL()
        {
            return productDL;
        }
    }
}
