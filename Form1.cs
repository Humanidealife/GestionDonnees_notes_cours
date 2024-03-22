using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDonnees_notes_cours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "C1";
            dataGridView1.Columns[0].HeaderText = "Utilisateur";
            dataGridView1.Columns[0].Width = 200;

            dataGridView1.Columns[1].Name = "C2";
            dataGridView1.Columns[1].HeaderText = "Mot de passse";
            dataGridView1.Columns[1].Width = 200;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }
    }
}
