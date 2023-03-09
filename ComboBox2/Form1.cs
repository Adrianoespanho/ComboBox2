using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                MessageBox.Show("Por favor digite algo", "aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            textBox1.Focus();
            {
                Seleciona.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // Seleciona.SelectedIndex = 0;
        }

        private void Remover_Click(object sender, EventArgs e)
        {

            if (Seleciona.SelectedIndex == 0) 
            
                MessageBox.Show("Por favor selecione um intem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                Seleciona.Items.Remove(Seleciona.SelectedItem);
                Seleciona.SelectedIndex = 0;
            }
            
         
          
          
        }

        private void Seleciona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
