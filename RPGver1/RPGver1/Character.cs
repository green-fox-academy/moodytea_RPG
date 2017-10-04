using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGver1
{
    class Character
    {
        public static int x = 1;
        public static int y = 1;
        

        public static FoxDraw foxDraw;
        

        public static void HeroPosition(int x, int y)
        {
                FloorPlan.DrawFloor(foxDraw);
        }

        public static void HeroStart(FoxDraw foxDraw)
        {
            Character.foxDraw = foxDraw;
            foxDraw.AddImage("./Assets/hero-down.png", x * 50, y * 50);
        }
        
        public static void HeroDown()
        {
            HeroPosition(x, y);
            if (FloorPlan.array[x, y+1] != 1)
            {
                foxDraw.AddImage("./Assets/hero-down.png", x * 50, (y += 1) * 50);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-down.png", x * 50, y * 50);
            }
            
        }
        public static void HeroUp()
        {
            HeroPosition(x, y);
            if (FloorPlan.array[x, y-1] != 1)
            {
                foxDraw.AddImage("./Assets/hero-up.png", x * 50, (y -= 1) * 50);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-up.png", x * 50, y * 50);
            }

        }
        public static void HeroRight()
        {
            HeroPosition(x, y);
            if (FloorPlan.array[x+1, y] != 1)
            {
                foxDraw.AddImage("./Assets/hero-right.png", (x += 1) * 50, y * 50);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-right.png", x * 50, y * 50);
            }

        }
        public static void HeroLeft()
        {
            HeroPosition(x, y);
            if (FloorPlan.array[x-1, y] != 1)
            {
                foxDraw.AddImage("./Assets/hero-left.png", (x -= 1) * 50, y * 50);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-left.png", x * 50, y * 50);
            }

        }

        public static void Boss()
        {
            foxDraw.AddImage("./Assets/boss.png", foxDraw.TILEWIDTH, 0);
        }
        public static void Skeleton()
        {
            foxDraw.AddImage("./Assets/skeleton.png", foxDraw.TILEWIDTH, 0);
        }

    }
}
