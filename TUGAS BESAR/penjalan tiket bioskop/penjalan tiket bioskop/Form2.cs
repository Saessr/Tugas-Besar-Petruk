using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace penjalan_tiket_bioskop
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "server=localhost;uid=root;password=;database=tiket_bioskop";

                string Query = "update tiket_bioskop.transaksi set no='" + this.notiket.Text + "',jenis_tiket='" + this.comboBox1.Text + "',harga='" + this.harga.Text + "',jumlah_beli='" + this.jumlahbeli.Text + "',total='" + this.total.Text + "',bayar='" + this.textBox1.Text + "',kembali='" + this.textBox2.Text + "' where no='" + this.notiket.Text + "';";
                 
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form3 tampil = new Form3();
            tampil.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                harga.Text = "35000";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                harga.Text = "50000";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                harga.Text = "75000";
            }
            else
            {
                harga.Text = "100000";
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            {
                Form3 kembali = new Form3();
                kembali.Show();
                this.Hide();
            }
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            {
                double t = double.Parse(total.Text);
                double b = double.Parse(textBox1.Text);
                textBox2.Text = (b - t).ToString();
            }
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            {
                double h = double.Parse(harga.Text);
                double j = double.Parse(jumlahbeli.Text);
                total.Text = (h * j).ToString();
            }
        }
    }
}
