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
        public static int x = 50;
        public static int y = 50;
        
        public static FoxDraw foxDraw;

        public static void HeroLastPosition(int x, int y)
        {
            if (x < 550 && x > 0 && y < 550 && y > 0)
            {
                FloorPlan.DrawFloor(foxDraw);
                //FloorPlan.DrawWall(foxDraw);
            }
         
        }

        public static void HeroStart(FoxDraw foxDraw)
        {
            Character.foxDraw = foxDraw;
            foxDraw.AddImage("./Assets/hero-down.png", x, y);
        }
        
        public static void HeroDown()
        {
            HeroLastPosition(x, y);
            if ( y <= 500)
            {
                foxDraw.AddImage("./Assets/hero-down.png", x, y += foxDraw.TILEHEIGHT);
            }
            
        }
        public static void HeroUp()
        {
            HeroLastPosition(x, y);
            if ( y > 0)
            {
                foxDraw.AddImage("./Assets/hero-up.png", x, y -= foxDraw.TILEHEIGHT);
            }
            
        }
        public static void HeroRight()
        {
            HeroLastPosition(x, y);
            if (x <= 500)
            {
                foxDraw.AddImage("./Assets/hero-right.png", x += foxDraw.TILEWIDTH, y);
            }

        }
        public static void HeroLeft()
        {
            HeroLastPosition(x, y);
            if (x > 0)
            {
                foxDraw.AddImage("./Assets/hero-left.png", x -= foxDraw.TILEWIDTH, y);
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
