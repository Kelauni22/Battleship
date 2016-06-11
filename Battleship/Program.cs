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

            //Make coordinates that equal false
            

           
            

                base_grid[0, 4] = false;
                base_grid[0, 9] = false;
                base_grid[2, 5] = false;
                base_grid[3, 1] = false;
                base_grid[4, 4] = false;
                base_grid[8, 8] = false;
                base_grid[7, 6] = false;
                base_grid[2, 2] = false;
                base_grid[5, 9] = false;
                base_grid[9, 7] = false;


                //Write an if statement if person hits a spot, display new screen

                Console.WriteLine("\n" + "Pick a number for coordinate 'x'");
                string x_pick_string = Console.ReadLine();
                int x_pick = Convert.ToInt16(x_pick_string);


                Console.WriteLine("Pick a number for coordinate 'y'");
                string y_pick_string = Console.ReadLine();
                int y_pick = Convert.ToInt16(y_pick_string);

            if (base_grid[x_pick, y_pick] == false)
            {
                Console.Clear();
                bool[,] new_grid = new bool[10, 10];

                for (int x = 0; x < 10; x++)

                {
                    for (int y = 0; y < 10; y++)
                    {
                        Console.Write("0");
                        if (new_grid[x, y] == base_grid[x_pick, y_pick])
                        {
                            Console.Write("*");
                        }

                        Console.Write("\n");
                    }

                }

            }

            else
            {
                Console.Write("\n" + "Sorry, you missed!");
            }

                Console.ReadLine();

            }

            //Write an if statement if person misses, keep same screen
            //Keep looping until all spots have been hit
            //Say good game once false

        
    }
}
