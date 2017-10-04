using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGver1
{
    class FloorPlan
    {
        public static int n = 12;
        public static int tile = 0;
        public static int wall = 1;

        public static int[,] array = new int[n, n];

        public static void SetWallValue(FoxDraw foxDraw)
        {
            for (int i = 0; i <= n-1; i++)
            {
                array[0, i] = 1;
                array[i, 0] = 1;
            }
            for (int i = 0; i <= n - 1; i++)
            {
                array[n - 1, i] = 1;
                array[i, n - 1] = 1;
            }
            array[1, 4] = 1;

            array[2, 2] = 1;
            array[2, 4] = 1;
            array[2, 5] = 1;
            array[2, 6] = 1;
            array[2, 8] = 1;
            array[2, 10] = 1;

            array[3, 2] = 1;
            array[3, 4] = 1;
            array[3, 8] = 1;

            array[4, 1] = 1;
            array[4, 2] = 1;
            array[4, 4] = 1;
            array[4, 5] = 1;
            array[4, 6] = 1;
            array[4, 8] = 1;
            array[4, 9] = 1;
            array[4, 10] = 1;

            array[6, 1] = 1;
            array[6, 2] = 1;
            array[6, 3] = 1;
            array[6, 4] = 1;
            array[6, 6] = 1;
            array[6, 7] = 1;
            array[6, 9] = 1;
            array[6, 10] = 1;

            array[7, 4] = 1;
            array[7, 6] = 1;
            array[7, 7] = 1;
            array[7, 9] = 1;

            array[8, 1] = 1;
            array[8, 2] = 1;
            array[8, 4] = 1;

            array[9, 1] = 1;
            array[9, 2] = 1;
            array[9, 4] = 1;
            array[9, 5] = 1;
            array[9, 6] = 1;
            array[9, 7] = 1;
            array[9, 8] = 1;
            array[9, 9] = 1;
        }

        public static void DrawFloor(FoxDraw foxDraw)
        {
            SetWallValue(foxDraw);
            int i, j; 
            for (i = 1; i <= n - 2; i++)
            {
                for (j = 1; j <= n - 2; j++)
                {
                    if (array[i, j] == 0)
                    {
                        DrawSingleTile(foxDraw, i, j);
                    }
                    else
                    {
                        DrawSingleWall(foxDraw, i, j);
                    }
                }
                
            }

        }

        public static void DrawSingleTile(FoxDraw foxDraw, int i, int j)
        {
            int x = i * foxDraw.TILEWIDTH;
            int y = j * foxDraw.TILEHEIGHT;
            foxDraw.AddImage("./Assets/floor.png", x, y);

        }
        public static void DrawSingleWall(FoxDraw foxDraw, int i, int j)
        {
            int x = i * foxDraw.TILEWIDTH;
            int y = j * foxDraw.TILEHEIGHT;
            foxDraw.AddImage("./Assets/wall.png", x, y);

        }
        
       

    }
}
