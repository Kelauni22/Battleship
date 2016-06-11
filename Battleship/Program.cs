using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            //00000000
            //0000*000
            //00**0000
            //00000000
            //000**000
            //*0*00000
            //00000**0
            //00****00
            //Color[,] pixels = new Color[imageWidth, imageHeight];
            //for (int x = 0; x <= imageWidth; ++x)
           // {
           //     for (int y = 0; y <= imageHeight; ++y)
            //    {
            //        pixels[x, y] = backgroundColor;
           //     }
           // }


            //Make a battleship screen of spots that all equal true

            bool[,] base_grid = new bool[10,10];

            for (int x = 0; x < 10; x++)
           
            {
                for (int y = 0; y < 10; y++)
                {
                    base_grid[x, y] = true;
                    Console.Write("0");
                              

                }

                Console.Write("\n");

            }

            



            Console.ReadLine();





















            //Make coordinates that equal false
            //Write an if statement if person hits a spot, display new screen
            //Write an if statement if person misses, keep same screen
            //Keep looping until all spots have been hit
            //Say good game once false

        }
    }
}
