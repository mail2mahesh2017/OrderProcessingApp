using System;
using System.Collections.Generic;
using OrderProcessingApplication.OrderProcessingClass;
using System.Text;

namespace OrderProcessingApplication
{
    class Other : PhysicalProduct
    {
        public Other(string name)
        {
            ItemName = name;
            Operations = new List<string>();
            base.GetSlip();
            base.AddCommission();
        }
    }
}
