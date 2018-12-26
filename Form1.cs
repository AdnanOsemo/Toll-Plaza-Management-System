using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsemoTollPlazaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form3 f = new Form3();
            if (textBox1.Text == "Adnan" && textBox2.Text == "12345")
            {
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Either your Username or Password is incorrect.","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);



            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources._1200px_Caseta_San_Marcos__Mexico_Puebla_;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer tm = new Timer();
            tm.Interval = 1500;
            tm.Tick += new EventHandler(chageimage);
            tm.Start();

            
        }

        private void chageimage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._1200px_Caseta_San_Marcos__Mexico_Puebla_);
            b1.Add(Properties.Resources.EZ_Pass_Pennsylvania_Bensalem);
            b1.Add(Properties.Resources.toll_plaza_electronic_e1462953196628);
            int index = DateTime.Now.Second % b1.Count;
            pictureBox1.Image = b1[index];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You really want to Exit...!","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Application.Exit();
            }
           
                
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "username")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "username";

                textBox1.ForeColor = Color.Black;
            }
        }

        

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fb_Click(object sender, EventArgs e)
        {

        }

        private void gm_Click(object sender, EventArgs e)
        {

        }

        private void tw_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
