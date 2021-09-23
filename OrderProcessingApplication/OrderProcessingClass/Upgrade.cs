using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.OrderProcessingClass
{
    class Upgrade : NonPhysicalProduct
    {
        public Upgrade()
        {
            Operations = new List<string>();
            base.GetSlip();
            Operations.Add("Apply the upgrade");
            Console.WriteLine("Apply the upgrade");
            base.DropMail();
        }
    }
}
