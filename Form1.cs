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

namespace DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Yasiru Tishan\Desktop\DBTest\reg.tish.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO RegGID VALUES(" + textBox5.Text + ",'" + textBox1.Text + "'," + textBox2.Text + ",'" + textBox3.Text + "','" + textBox4.Text + "') ";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Successfully");
            }

            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string deleteqry = "DELETE FROM RegGID WHERE RegID=(" + textBox5.Text + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
            }

            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string updateqry = "Update RegGID set RegID=" + textBox5.Text + ",Name='" + textBox1.Text + "',Age=" + textBox2.Text + ",School='" + textBox3.Text + "',DOB='" + textBox4.Text + "' where RegID = " + textBox5.Text + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }

            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }
    }
}
