namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        public int speedpong_left = 85;
        public int ballspeed_left = 10;
        public int ballspeed_top = 10;
        public int scores = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racketa.Top = panel.Bottom - (panel.Bottom / 10);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            balla.Left += ballspeed_left;
            balla.Top += ballspeed_top;
            if (balla.Top <= panel.Top)
            {
                ballspeed_top = -ballspeed_top;
                ballspeed_top = ballspeed_top + 1;
                if (ballspeed_top > 20)
                {
                    ballspeed_top--;
                    ballspeed_left--;
                }

            }
            if (balla.Left <= panel.Left)
            {
                ballspeed_left = -ballspeed_left;
            }
            if (balla.Right >= panel.Right)
            {
                ballspeed_left = -ballspeed_left;
            }
            if (balla.Bottom >= panel.Bottom)
            {
                timer1.Enabled = false;
            }
            if (balla.Bottom >= racketa.Top && balla.Bottom <= racketa.Bottom && balla.Left >= racketa.Left && balla.Right <= racketa.Right)
            {
                ballspeed_top = -ballspeed_top;
                ballspeed_left = ballspeed_left + 1;
                scores++;
                scorea.Text = scores.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                balla.Top = 190;
                balla.Left = 90;
                ballspeed_left = 10;
                ballspeed_top = 10;
                timer1.Enabled = true;
                scores = 0;
                scorea.Text = "0";
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.A)
            {
                racketa.Left -= speedpong_left;
            }
            if (e.KeyCode == Keys.D)
            {
                racketa.Left += speedpong_left;
            }
            if (e.KeyCode == Keys.B)
            {

                balla.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }
            if (e.KeyCode == Keys.N)
            {
                racketa.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }
            if (e.KeyCode == Keys.M)
            {
                this.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }

        }
    }
}