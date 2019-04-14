using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tweet_deneme123
{
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            InitializeComponent();
        }
        
        private void GİRİŞ_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kenan" && textBox2.Text == "1234")
            {
                Form1 girisForma = new Form1();
                girisForma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ");
            }
        }

    }
}
