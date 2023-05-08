using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace gokaysinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listele()
        {
            SQLiteConnection baglanti =
                new SQLiteConnection("Data Source=D:\\gokay2.db;version=3");
            baglanti.Open();
            SQLiteDataAdapter da =
                new SQLiteDataAdapter("SELECT * FROM sinema", baglanti);
            DataSet ds = new DataSet();
             da.Fill(ds, "knumara");
            dataGridView1.DataSource = ds.Tables["knumara"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti =
               new SQLiteConnection("Data Source=D:\\gokay2.db;version=3");
            baglanti.Open();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
