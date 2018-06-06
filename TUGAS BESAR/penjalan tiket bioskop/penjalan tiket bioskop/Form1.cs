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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnproses_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(harga.Text);
            double j = double.Parse(jumlahbeli.Text);
            total.Text = (h * j).ToString();
        }

       

        private void btnlanjut_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost; user=root; password=; database=tiket_bioskop";
                string query = "insert into tiket_bioskop.transaksi(jenis_tiket,harga,jumlah_beli,total,bayar,kembali) values ('" + this.comboBox1.Text + "','" + this.harga.Text + "','" + this.jumlahbeli.Text + "','" + this.total.Text + "','" + this.bayar.Text + "','" + this.kembali.Text + "') ";
                MySqlConnection conn2 = new MySqlConnection(connStr);
                MySqlCommand command2 = new MySqlCommand(query, conn2);
                MySqlDataReader myreader2;
                conn2.Open();
                myreader2 = command2.ExecuteReader();
                MessageBox.Show("Data Tersimpan");
                while (myreader2.Read())
                {
                }
                conn2.Close();
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
            if(comboBox1.SelectedIndex == 1)
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

        private void total_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            double t = double.Parse(total.Text);
            double b = double.Parse(bayar.Text);
            kembali.Text = (b - t).ToString();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form3 kembali = new Form3();
            kembali.Show();
            this.Hide();
        }
    }
}
