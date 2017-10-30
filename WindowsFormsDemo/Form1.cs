using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Character Hero = new Character();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
        }

        public  void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            health.Visible = true;
            health_num.Visible = true;
            Name1.Visible = true;
            Damage.Visible = true;
            Damage_num.Visible = true;
            Defend.Visible = true;
            Defend_num.Visible = true;
            if (checkBox1.Checked == true)
                Hero.Getgender(1);
            else
                Hero.Getgender(0);
            health_num.Text = Convert.ToString (Hero.Gethealth((int)numericUpDown2.Value));
            Name1.Text = Hero.Getname(textBox1.Text);
            Damage_num .Text = Convert.ToString(Hero.Getdamage((int)numericUpDown3.Value));
            Defend_num .Text = Convert.ToString(Hero.Getdefend((int)numericUpDown4.Value));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            numericUpDown2.Value += 1;
            health_num.Text = Convert.ToString(Hero.Gethealth((int)numericUpDown2.Value));
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }

}
