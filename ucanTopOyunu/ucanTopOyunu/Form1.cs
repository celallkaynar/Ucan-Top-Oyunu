namespace ucanTopOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 10, yerY = 10, can = 3;

        private void YanmaOlayi(object sender, EventArgs e)
        {
            if (Top.Top >= labelSag.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Kalan Can:" + can.ToString(), "Yand�n�z!");
                    Form1_Load(sender, e);
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti", "", MessageBoxButtons.OK);
                }
            }
            labelCan.Text = can.ToString();
        }
        private void TopBasa()
        {
            Top.Location = new Point(206, 185);
        }
        private void CarpmaOlayi()
        {
            //�ste �arpma
            if (Top.Top <= labelUst.Bottom)
                yerY = yerY * -1;
            //bize �arpma
            if (Top.Bottom >= Biz.Top && Top.Right <= Biz.Right && Top.Left >= Biz.Left)
                yerY = yerY * -1;
            //sola �arpma
            if (Top.Left >= labelSol.Right)
                yerX = yerX * -1;
            //sa�a �arpma
            if (Top.Right <= labelSag.Left)
                yerX = yerX * -1;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Biz.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopBasa();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Top.Location = new Point(Top.Location.X + yerX, Top.Location.Y + yerY);
            CarpmaOlayi();
            YanmaOlayi(sender, e);
        }
    }
}