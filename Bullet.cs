using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Spacebattle
{
    class Bullet:PictureBox
    {
        private Timer timerBulletMove;
        int verVelocity = 0;
        int horVelocity = 0;
        int bulletStep = 5;
        public Bullet()
        {
            InitializeTimerBulletMove();
            InitializeBullet();
        }

        private void InitializeTimerBulletMove()
        {
            timerBulletMove = new Timer();
            timerBulletMove.Interval = 20;
            timerBulletMove.Tick += new EventHandler(TimerBulletMove_Tick);
            verVelocity = -bulletStep;
            timerBulletMove.Start();
        }
        private void TimerBulletMove_Tick(object sender, EventArgs e)
        {
            this.Top += verVelocity;
            this.Left += horVelocity;
            if (this.Top < 0)
            {
                this.Dispose();
            }
        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Red;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
