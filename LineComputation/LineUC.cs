using System;
using System.Collections.Generic;
using System.Text;

namespace LineComputation
{
    public class LineUC
    {
        public void LineComp()
        {
            Console.WriteLine("Length of a Line");
            Console.WriteLine("_________________");
            //x1
            string userx1;
            double x1;
            Console.Write("Enter INPUT x1: ");
            userx1 = Console.ReadLine();
            /* Converts to double type */
            x1 = Convert.ToDouble(userx1);
            Console.WriteLine("Input x1 : " + x1);

            //y1
            string usery1;
            double y1;
            Console.Write("Enter INPUT y1: ");
            usery1 = Console.ReadLine();
            /* Converts to double type */
            y1 = Convert.ToDouble(usery1);
            Console.WriteLine("Input y1 : " + y1);

            //x2
            string userx2;
            double x2;
            Console.Write("Enter INPUT x2: ");
            userx2 = Console.ReadLine();
            /* Converts to double type */
            x2 = Convert.ToDouble(userx2);
            Console.WriteLine("Input x2 : " + x2);

            //y2
            string usery2;
            double y2;
            Console.Write("Enter INPUT y2: ");
            usery2 = Console.ReadLine();
            /* Converts to double type */
            y2 = Convert.ToDouble(usery2);
            Console.WriteLine("Input y2: " + y2);

            double lin_len = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of a Line is : " + lin_len);
            Console.WriteLine("---------------------------------------");
        }
    }
}
