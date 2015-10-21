using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
                   

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 7, '$');
            Point p4 = new Point(12, 15, '@');
            Point p5 = new Point(17, 25, '&');
            List<int> numLIst = new List<int>();
            numLIst.Add(0);
            numLIst.Add(1);
            numLIst.Add(2);

            int x = numLIst[0];
            int y = numLIst[1];
            int z = numLIst[2];

            foreach (int i in numLIst)
            {
                Console.WriteLine(i);
            }

            numLIst.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);

            /*lesson-6*/

            Console.ReadLine();
        }
        
        
    }
}
