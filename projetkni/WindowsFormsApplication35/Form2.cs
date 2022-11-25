using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication35
{
    public partial class Form2 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection();
        public Form2()
        {
            konekcija.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amard\Desktop\database233.mdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            konekcija.Open();
            OleDbCommand komand = new OleDbCommand();
            komand.Connection = konekcija;
            komand.CommandText = "INSERT INTO Table1 ([Username],[Password]) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            komand.ExecuteNonQuery();
            MessageBox.Show("New account has been registered");
        }
    }
}
