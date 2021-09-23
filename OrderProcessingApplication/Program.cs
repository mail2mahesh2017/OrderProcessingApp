using OrderProcessingApplication.OrderProcessingClass;
using System;
using System.Collections.Generic;
using static OrderProcessingApplication.Program;

namespace OrderProcessingApplication
{
    /* <summary>
     
    Imagine you’re writing an order processing application for a large company. In the past, this company used a fairly
    random mixture of manual and ad-hoc automated business practices to handle orders; they now want to put all these
    various ways of hanadling orders together into one whole: your application.After a full day of workshops you have
    gathered the following set of rules which need to be managed by the new system.
    
    </summary> */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product type and name seperated by space");
            var input = Console.ReadLine().Split(' ');
            var output = OrderProcessor.ConvertInputToType(input);
            Console.WriteLine("Item Name : {0} Operations : {1}", output.ItemName, string.Join(' ', output.Operations));
            Console.ReadLine();
        }
    }

    
}
