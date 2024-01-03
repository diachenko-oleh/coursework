using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Form1 : Form
    {
        Side t1_1 = new Side(101, 100);
        Side t1_2 = new Side(187, 100);
        Side t1_3 = new Side(143, 175);
        Side t1_4 = new Side(144, 125);

        Side t2_1 = new Side(351, 100);
        Side t2_2 = new Side(437, 100);
        Side t2_3 = new Side(393, 175);
        Side t2_4 = new Side(394, 125);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            t1_1.Paint();
            t1_4.Paint();
            t1_2.Paint();
            t1_3.Paint();
            if (IsFullPainted(t1_1, t1_2, t1_3, t1_4))
            {
                MessageBox.Show("Тетраедр повністю пофарбований");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            t2_1.Paint();
            t2_4.Paint();
            t2_2.Paint();
            t2_3.Paint();
            if (IsFullPainted(t2_1, t2_2, t2_3, t2_4))
            {
                MessageBox.Show("Тетраедр повністю пофарбований");
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            t1_1.Draw(false);
            t1_2.Draw(false);
            t1_3.Draw(false);
            t1_4.Draw(true);
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            t2_1.Draw(false);
            t2_2.Draw(false);
            t2_3.Draw(false);
            t2_4.Draw(true);
        }
        private bool IsFullPainted(Side s1, Side s2, Side s3, Side s4)
        {
            Color[] colors = { s1.colour, s2.colour, s3.colour, s4.colour };
            var colorsCounts = colors.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            foreach (var item in colorsCounts)
            {
                if (item.Value >= 3)
                {
                    return true;
                }
            }
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsEqual(t1_1, t1_2, t1_3, t1_4,t2_1, t2_2, t2_3, t2_4))
            {
                MessageBox.Show("Тетраедри пофарбовані однаково");
            }
            else
            {
                MessageBox.Show("Невідповідна комбінація кольорів");
            }
        }
        private bool IsEqual(Side s1, Side s2, Side s3, Side s4, Side s1_, Side s2_, Side s3_, Side s4_)
        {
            if (s1.colour == s1_.colour && s2.colour == s2_.colour && s3.colour == s3_.colour && s4.colour == s4_.colour)
            {
                return true;
            }
            return false;
        }
    }
}
