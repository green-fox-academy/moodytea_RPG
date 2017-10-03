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
        public static int n = 11;
        public static int tile = 0;
        public static int wall = 1;

        public static bool isItFloor(FoxDraw foxDraw)
        {
            if (!= wall)
                return true;
            else
                return false;
        }

        public static void DrawFloor(FoxDraw foxDraw)
        {

        }

        public static void DrawFloor(FoxDraw foxDraw)
        {

            int x, y;
            x = 0;
            y = 0;

            int i, j; 
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    x += foxDraw.TILEWIDTH;
                    foxDraw.AddImage("./Assets/floor.png", x, y);
                }
                y += foxDraw.TILEHEIGHT;
                x = 0;
            }

        }
        public static void DrawSingleWall(FoxDraw foxDraw, int i, int j)
        {
            int x = i * foxDraw.TILEWIDTH;
            int y = j * foxDraw.TILEHEIGHT;
            foxDraw.AddImage("./Assets/wall.png", x, y);

        }
        public static void DrawWall(FoxDraw foxDraw)
        {
            FloorPlan.DrawSingleWall(foxDraw, 4, 0);
            FloorPlan.DrawSingleWall(foxDraw, 4, 1);
            FloorPlan.DrawSingleWall(foxDraw, 4, 2);
            FloorPlan.DrawSingleWall(foxDraw, 3, 2);
            FloorPlan.DrawSingleWall(foxDraw, 2, 2);

            FloorPlan.DrawSingleWall(foxDraw, 4, 4);
            FloorPlan.DrawSingleWall(foxDraw, 4, 5);
            FloorPlan.DrawSingleWall(foxDraw, 4, 6);
            FloorPlan.DrawSingleWall(foxDraw, 3, 4);
            FloorPlan.DrawSingleWall(foxDraw, 2, 4);
            FloorPlan.DrawSingleWall(foxDraw, 2, 5);
            FloorPlan.DrawSingleWall(foxDraw, 2, 6);
            FloorPlan.DrawSingleWall(foxDraw, 1, 4);

            FloorPlan.DrawSingleWall(foxDraw, 4, 8);
            FloorPlan.DrawSingleWall(foxDraw, 4, 9);
            FloorPlan.DrawSingleWall(foxDraw, 4, 10);
            FloorPlan.DrawSingleWall(foxDraw, 3, 8);
            FloorPlan.DrawSingleWall(foxDraw, 2, 8);
            FloorPlan.DrawSingleWall(foxDraw, 2, 10);

            FloorPlan.DrawSingleWall(foxDraw, 6, 0);
            FloorPlan.DrawSingleWall(foxDraw, 6, 1);
            FloorPlan.DrawSingleWall(foxDraw, 6, 2);
            FloorPlan.DrawSingleWall(foxDraw, 6, 3);
            FloorPlan.DrawSingleWall(foxDraw, 6, 4);
            FloorPlan.DrawSingleWall(foxDraw, 6, 6);
            FloorPlan.DrawSingleWall(foxDraw, 6, 7);
            FloorPlan.DrawSingleWall(foxDraw, 6, 9);
            FloorPlan.DrawSingleWall(foxDraw, 6, 10);

            FloorPlan.DrawSingleWall(foxDraw, 7, 4);
            FloorPlan.DrawSingleWall(foxDraw, 7, 6);
            FloorPlan.DrawSingleWall(foxDraw, 7, 7);
            FloorPlan.DrawSingleWall(foxDraw, 7, 9);

            FloorPlan.DrawSingleWall(foxDraw, 8, 1);
            FloorPlan.DrawSingleWall(foxDraw, 8, 2);
            FloorPlan.DrawSingleWall(foxDraw, 8, 4);


            FloorPlan.DrawSingleWall(foxDraw, 9, 1);
            FloorPlan.DrawSingleWall(foxDraw, 9, 2);
            FloorPlan.DrawSingleWall(foxDraw, 9, 4);
            FloorPlan.DrawSingleWall(foxDraw, 9, 5);
            FloorPlan.DrawSingleWall(foxDraw, 9, 6);
            FloorPlan.DrawSingleWall(foxDraw, 9, 7);
            FloorPlan.DrawSingleWall(foxDraw, 9, 8);
            FloorPlan.DrawSingleWall(foxDraw, 9, 9);

            FloorPlan.DrawSingleWall(foxDraw, 11, 1);
            FloorPlan.DrawSingleWall(foxDraw, 11, 5);
            FloorPlan.DrawSingleWall(foxDraw, 11, 6);
            FloorPlan.DrawSingleWall(foxDraw, 11, 7);
            FloorPlan.DrawSingleWall(foxDraw, 11, 8);
            FloorPlan.DrawSingleWall(foxDraw, 11, 9);
            FloorPlan.DrawSingleWall(foxDraw, 11, 10);
            


        }

    }
}
