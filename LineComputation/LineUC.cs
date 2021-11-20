using System;
using System.Collections.Generic;
using System.Text;

namespace LineComputation
{
    public class LineUC
    {
        public void LineComp()
        {
            Console.WriteLine("Comparison Length of a Line 1 and Line 2 equal or not :- ");
            Console.WriteLine("_________________");
            //line 1
            Console.WriteLine("Coordinates of Line 1 :- ");
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

            //Length of line 1
            double lin_len1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of a Line is : " + lin_len1);
            Console.WriteLine("---------------------------------------");

            //line 2
            Console.WriteLine("Coordinates of Line 2 :- ");
            //x3
            string userx3;
            double x3;
            Console.Write("Enter INPUT x3: ");
            userx3 = Console.ReadLine();
            /* Converts to double type */
            x3 = Convert.ToDouble(userx3);
            Console.WriteLine("Input x3 : " + x3);

            //y3
            string usery3;
            double y3;
            Console.Write("Enter INPUT y3: ");
            usery3 = Console.ReadLine();
            /* Converts to double type */
            y3 = Convert.ToDouble(usery3);
            Console.WriteLine("Input y3 : " + y3);

            //x4
            string userx4;
            double x4;
            Console.Write("Enter INPUT x4: ");
            userx4 = Console.ReadLine();
            /* Converts to double type */
            x4 = Convert.ToDouble(userx4);
            Console.WriteLine("Input x4 : " + x4);

            //y4
            string usery4;
            double y4;
            Console.Write("Enter INPUT y4: ");
            usery4 = Console.ReadLine();
            /* Converts to double type */
            y4 = Convert.ToDouble(usery4);
            Console.WriteLine("Input y4: " + y4);

            //Length of line 2
            double lin_len2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("Length of a Line is : " + lin_len2);
            Console.WriteLine("---------------------------------------");

            //Equal or not
            //Boolean eq;
            //eq=lin_len1.equals(lin_len2);

            if (lin_len1.CompareTo(lin_len2) == 0)
            {

                Console.WriteLine("EQUAL");

            }

            else if (lin_len1.CompareTo(lin_len2) > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {

                Console.WriteLine("Line 1 is smaller than Line 2");

            }

        }
    }
}
