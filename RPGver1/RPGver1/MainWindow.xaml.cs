using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;
namespace RPGver1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            FloorPlan.DrawFloor(foxDraw);
            FloorPlan.DrawWall(foxDraw);
            Character.HeroStart(foxDraw);


        }
        void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
               Character.HeroLeft();
            }

            else if (e.Key == Key.Right)
            {
               Character.HeroRight();
            }

            else if (e.Key == Key.Up)
            {
                Character.HeroUp();
            }

            else if (e.Key == Key.Down)
            {
                Character.HeroDown();
            }


        }

    }
}