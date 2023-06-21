using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Encaptulation
    {
        // creating feilds for static constructor

        public static string productName { get; set; }


        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public DateTime? PackageDate { get; set; }


        //static constructor
        static Encaptulation()
        {
            productName = "SK Arecanut";
        }

        public Encaptulation()
        {
            this.ProductID = 1;
            this.ProductName = "SK Arecanut 1";
            this.CategoryID = 1;
            this.PackageDate = DateTime.Now;    
        }

    }
}
