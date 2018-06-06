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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form3 tampil = new Form3();
            tampil.Show();
            this.Hide();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost; uid=root; pwd=; database=tiket_bioskop";
                string Query = "delete from tiket_bioskop.transaksi where no='" + this.no.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(connStr);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Telah Dihapus");
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
    }
}
