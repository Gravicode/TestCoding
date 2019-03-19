using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soal03
{
    public partial class GameForm : Form
    {
        static bool Animating = false;
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);
        public GameForm()
        {
            InitializeComponent();
            BtnStart.Click += (a,b)=> {
                CancellationTokenSource source = new CancellationTokenSource();
                if (!Animating)
                {
                    BtnStart.Text = "&Stop";
                    Task tsk = new Task(()=> { StartAnimation(source.Token); });
                    tsk.Start();
                    Animating = true;
                    
                }
                else
                {
                    Animating = false;
                    source.Cancel();
                    BtnStart.Text = "&Start";
                }

            };
        }

        

        async void StartAnimation(CancellationToken token)
        {
            GameObject game = new GameObject(pictureBox1.Width,pictureBox1.Height);
            g = pictureBox1.CreateGraphics();
            while (true)
            {
                g.Clear(Color.Black);
                game.MoveObjects();

                //draw stars
                foreach(var item in game.AllStars)
                {
                    pen1 = new Pen(new SolidBrush(item.Warna));
                    g.DrawRectangle(pen1, new Rectangle((int)item.X,(int) item.Y, 1, 1));
                }

                if (token.IsCancellationRequested || !Animating) break;
                //pictureBox1.Refresh();
                Thread.Sleep(20);

            }
        }
    }
}
