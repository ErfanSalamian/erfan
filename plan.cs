using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projects
{
    public partial class plan : Form
    {
        public plan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string namesahebbar = textBox1.Text;
                string mobilesahebbar = textBox2.Text;
                string noebar = textBox3.Text;
                string vaznebarevorody = textBox4.Text;
                string tarikhevorod = textBox5.Text;
                string shomareanbar = textBox6.Text;
                string namekharidar = textBox7.Text;
                string mobilekharidar = textBox8.Text;
                string vaznebarekhorogy = textBox9.Text;
                string tarikhekhorog = textBox10.Text;
                string query = "INSERT INTO plan (namesahebbar,mobilesahebbar,noebar,vaznebarevorody,tarikhevorod,shomareanbar,namekharidar,mobilekharidar,vaznebarekhorogy,tarikhekhorog)" +
                    "VALUES ('"+ namesahebbar + "','"+ mobilesahebbar + "','"+ noebar + "','"+ vaznebarevorody + "','"+ tarikhevorod + "','"+ shomareanbar + "','"+ namekharidar + "','"+ mobilekharidar + "','"+ vaznebarekhorogy + "','"+ tarikhekhorog + "')";
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\MoDeRN Pc\\source\\repos\\projects\\projects\\Database1.mdf\";Integrated Security=True");
                sc.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sc);
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("insert ok");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
                }
                else
                {
                    MessageBox.Show("insert no");
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
    }
}
