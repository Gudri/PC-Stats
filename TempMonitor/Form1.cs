using System;
using System.Drawing;
using System.Windows.Forms;

namespace TempMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }                             // Drag and Drop

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }          // Dugme za izlaz.

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Meni.Visible)
            {
                Sakrivanje.HideSync(Meni);
                Refresh();
            }
            else
            {
                Prikazivanje.ShowSync(Meni);
                Refresh();
            }
        }          // Animirani Meni.

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }           // Otvori About Box.

        private void Timer1_Tick(object sender, EventArgs e)
        {
            float cpu = CPU.NextValue();
            cpuUsage.Value = (int)cpu;
            label4.Text = string.Format("{0:0}%", cpu);

            float ram = RAM.NextValue();
            ramUsage.Value = (int)ram;
            label5.Text = string.Format("{0:0}%", ram);

        }

        private void XuiRadio1_Click(object sender, EventArgs e)
        {
            Refresh();
            label1.BackColor = Color.FromArgb(29, 29, 29);
            label1.ForeColor = Color.White;
            bunifuImageButton1.BackColor = Color.FromArgb(29, 29, 29);
            bunifuImageButton2.BackColor = Color.FromArgb(29, 29, 29);
            panel2.BackColor = Color.FromArgb(39, 39, 39);
            Meni.BackColor = Color.FromArgb(34, 34, 34);
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            xuiRadio1.ForeColor = Color.White;
            xuiRadio2.ForeColor = Color.White;
            xuiRadio3.ForeColor = Color.White;
            xuiRadio4.ForeColor = Color.White;
            pictureBox1.BackgroundImage = PCStats.Properties.Resources.picture_dark;
            Refresh();
        }

        private void XuiRadio2_Click(object sender, EventArgs e)
        {
            Refresh();
            label1.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            bunifuImageButton1.BackColor = Color.WhiteSmoke;
            bunifuImageButton2.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.White;
            Meni.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            xuiRadio1.ForeColor = Color.Black;
            xuiRadio2.ForeColor = Color.Black;
            xuiRadio3.ForeColor = Color.Black;
            xuiRadio4.ForeColor = Color.Black;
            pictureBox1.BackgroundImage = PCStats.Properties.Resources.picture_light;
            Refresh();
        }

    }

}
