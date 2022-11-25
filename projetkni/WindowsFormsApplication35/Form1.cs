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
    
    public partial class Form1 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection();
     
        public Form1()
        {
            InitializeComponent();
            konekcija.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amard\Desktop\database233.mdb; Persist Security Info=False;";
        }
  
        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password, Game, Date, Price;


            Username = textBox1.Text;
            Password = textBox2.Text;
            Game = comboBox2.SelectedItem .ToString();
            Date = dateTimePicker2.Text.ToString();
            Price = comboBox3.SelectedItem.ToString();
            
            if (radioButton1.Checked)
            {
                
                
                listBox1.Items.Add("Username :" + Username +"\n");
                listBox1.Items.Add("Game :" + Game + "\n");
                listBox1.Items.Add("Date of Purchuse :" + Date + "\n");
                listBox1.Items.Add("Game Price :" + Price + "\n");
             
                
                
                 
            }
            else if (radioButton2.Checked)
            {


                listBox2.Items.Add("Username :" + Username + "\n");
                listBox2.Items.Add("Game :" + Game + "\n");
                listBox2.Items.Add("Date of Purchuse :" + Date + "\n");
                listBox2.Items.Add("Game Price :" + Price + "\n");
             
                
                
            }
            else if (radioButton3.Checked)
            {

                listBox3.Items.Add("Username :" + Username + "\n");
                listBox3.Items.Add("Game :" + Game + "\n");
                listBox3.Items.Add("Date of Purchuse :" + Date + "\n");
                listBox3.Items.Add("Game Price :" + Price + "\n");
             
             
            }



            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox2.Items.Add("Battlefield 1");
            comboBox2.Items.Add("PlayerUnkowns BattleGround");
            comboBox2.Items.Add("Call of Duty : WWII");
            comboBox2.Items.Add("Destiny 2");
            comboBox2.Items.Add("Batman Arkham Knight");
            comboBox2.Items.Add("Doom (2016)");
            comboBox2.Items.Add("Counter Strike : Global Offensive");
            comboBox2.Items.Add("Assassin's Creed : Origins");
            comboBox2.Items.Add("Dragon Ball FighterZ");
            comboBox3.Items.Add("60$");
            comboBox3.Items.Add("50$");
            comboBox3.Items.Add("40$");

            
            konekcija.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amard\Desktop\database233.mdb;
Persist Security Info=False;";
            konekcija.Open();
            checkKonekcija.Text = "Konekcija uspijesna";
            konekcija.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                    case 0:

                    pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/BF1.jpg");
            break;
                    case 1:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/PUBG.jpg");

            break;
                    case 2:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/COD.png");
            break;
                    case 3:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/D2.jpg");
            break;
                    case 4:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/BAK.jpg");
            break;
                    case 5:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/DM.jpg");
            break;
                    case 6:

            pictureBox1.Image = System.Drawing.Image.FromFile("D:/projetkni/slike/CS.jpg");
            break;
                
            
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            konekcija.Open();
            OleDbCommand komand = new OleDbCommand();
            komand.Connection = konekcija;
            komand.CommandText = "select * from table1 where Username='"+textBox1.Text+"'and'"+textBox2.Text+"'";
            OleDbDataReader citaj = komand.ExecuteReader();
            int c = 0;
            while (citaj.Read())
            {
                c = c + 1;
            }
            if (c == 1)
            {
                MessageBox.Show("Your log in was sucssesful");
            }
            if (c > 1)
            { 
               MessageBox.Show("This account is a dup.");
            }
            else if (c!=1)
            {
            MessageBox.Show("Your log in was met with a error, please try again");
            }

            konekcija.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();

            
            settingsForm.Show();
        }

        
      
       

      

     

      
    }
}
