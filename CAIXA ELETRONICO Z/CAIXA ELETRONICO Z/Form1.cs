using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CAIXA_ELETRONICO_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            MySqlConnection conn = new MySqlConnection

        ("User id=root;Host=localhost;Database=banco;");
            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT into contas (cpf, numero, senha, saldo, limite) values('" +
            textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";

            try
            {
                int result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
   
    }
}
