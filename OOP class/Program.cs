using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Area a1 = new Area();
            a1.setName("Aksel");
            a1.Length = 20;
            a1.Width = 12;
            a1.Color = MyColorEnum.Blue;
            //Console.WriteLine(a1);


            Area a2 = new Area();
            a2.setName("Lars");
            a2.Length = 34;
            a2.Width = 13;
            a2.Color = MyColorEnum.Magenta;
            //Console.WriteLine(a2);


            Area a3 = new Area(MyColorEnum.Red,"Mark",16,7);
            //Console.WriteLine(a3);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                             Usorteret                                   *");
            Area[] areas = new Area[5];
            areas[0] = a1;
            areas[1] = a2;
            areas[2] = a3;
            areas[3] = new Area(MyColorEnum.Cyan,"Hansen", 6, 4);
            areas[4] = new Area(MyColorEnum.Green,"Babuska", 456, 567);
            foreach (Area obj in areas)
                Console.WriteLine(obj);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                             Sorteret                                    *");
            Array.Sort(areas);
            foreach (Area obj in areas)
                Console.WriteLine(obj);
            Console.WriteLine("***********************************************************************************************************");
            Console.WriteLine("*                                        CubeSorted                                                       *");
            /////////////////////////////////////////////////////////////////////////////////////
            ///Cubic;
            Cubic[] cubes = new Cubic[7];
            cubes[0] = new Cubic(20, areas[0]);
            cubes[1] = new Cubic(9, areas[1]);
            cubes[2] = new Cubic(5, areas[2]);
            cubes[3] = new Cubic(9,areas[3]);
            cubes[4] = new Cubic( 7, areas[4]);
            Cubic c1 = new Cubic();
            c1.Height = 11;
            c1.Width = 14;
            c1.Length = 9;
            c1.setName("Lars");
            c1.Color = MyColorEnum.Cyan;
            cubes[5] = c1;
            cubes[6] = new Cubic(MyColorEnum.Yellow,17,5,3,"Morten");
            Array.Sort(cubes);
            foreach (Cubic obj in cubes)
                Console.WriteLine(obj);
            Console.WriteLine("***********************************************************************************************************");
            //object[] objects = new object[5];
            //objects[0] = c1;
            //objects[1] = a1;
            //objects[2] = cubes[0];
            //objects[3] = a2;
            //objects[4] = cubes[1];
            //foreach(object o in objects)
            //{
            //    Console.WriteLine(o);
            //}

            Console.ReadKey();
        }
    }
}
