using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace penjalan_tiket_bioskop
{
    public partial class Form3 : Form
    {
        string connStr = "server=localhost; uid=root; password=; database=tiket_bioskop";
        MySqlConnection koneksi;
        MySqlCommand query;

        public Form3()
        {
            InitializeComponent();
        }
        public void loadData()
        {
        }


        private void btnubah_Click(object sender, EventArgs e)
        {
            Form2 ubh = new Form2();
            ubh.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
       
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            string uid = "root";
            string pass = "";
            string database = "tiket_bioskop";
            string connStr = "server= " + host + "; uid= " + uid + "; database= " + database + "; password= " + pass + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("Koneksi Sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;uid=root;password=;database=tiket_bioskop";
               
                string Query = "select * from tiket_bioskop.transaksi;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            form1 tambah = new form1();
            tambah.Show();
            this.Hide();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            Form4 hps = new Form4();
            hps.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void notiket_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
