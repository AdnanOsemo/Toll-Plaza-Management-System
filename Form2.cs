using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OsemoTollPlazaFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Paste your connection string here!");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO EmpTbl_Insertion (E_Id, E_Name, E_CNIC, E_Age, E_PNo, E_Address) VALUES ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Value inserted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex){
               
                MessageBox.Show(ex.Message);
                con.Close();
            
            }

            }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT *FROM EmpTbl_Insertion";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "UPDATE EmpTbl_Insertion SET E_Name = '" + textBox2.Text + "', E_CNIC ='" + textBox3.Text + "', E_Age ='" + textBox4.Text + "', E_PNo ='" + textBox5.Text + "', E_Address ='" + textBox6.Text + "' WHERE E_Id = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Value updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "DELETE FROM EmpTbl_Insertion WHERE E_Id = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Value deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();


            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
