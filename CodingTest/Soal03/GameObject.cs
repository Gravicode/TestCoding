using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal03
{
    public class GameObject
    {
        public int HeightScreen { get; set; }
        public int WidthScreen { get; set; }
        public class Stars
        {
            public Color Warna { get; set; }
            public float Y { get; set; }
            public float X { get; set; }

        }
        const int MaxStars = 500;
        public List<Stars> AllStars { get; set; }
        Random rnd;

        public GameObject(int Width,int Height)
        {
            rnd = new Random(Environment.TickCount);
            this.WidthScreen = Width;
            this.HeightScreen = Height;
            AllStars = new List<Stars>();
            for(int i = 0; i < MaxStars; i++)
            {
                AllStars.Add(new Stars() { Warna = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), X = (float) rnd.NextDouble()* WidthScreen, Y =(float) rnd.NextDouble()*HeightScreen });
            }
        }

        public void MoveObjects()
        {
            for(int i=0;i<MaxStars;i++)
            {
                var item = AllStars[i];
                item.X += rnd.Next(-2,2);
                item.Y += rnd.Next(2, 6);
                if (item.X < 0) item.X = WidthScreen-1;
                if (item.X > WidthScreen) item.X = 1;
                if (item.Y > HeightScreen)
                {
                    item.Y = -1;
                }
            }
        }
       
    }
}
