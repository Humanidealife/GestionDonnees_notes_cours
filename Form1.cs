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
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("Utilisateur" + i, "Mot de passe" + i);
            }

            Users u1 = new Users("A", "111");
            Users u2 = new Users("B", "222");
            Users u3 = new Users("C", "333");

            bindingSource1.Add(u1);
            bindingSource1.Add(u2);
            bindingSource1.Add(u3);

            chart1.Series["Moyenne"].Points.AddXY("Math", 15);
            chart1.Series["Moyenne"].Points.AddXY("Physique", 12);
            chart1.Series["Moyenne"].Points.AddXY("Français", 18);
            chart1.Series["Moyenne"].Points.AddXY("Anglais", 14);

            chart1.Series["Moyenne an dernier"].Points.AddXY("Math", 18);
            chart1.Series["Moyenne an dernier"].Points.AddXY("Physique", 10);
            chart1.Series["Moyenne an dernier"].Points.AddXY("Français", 15);
            chart1.Series["Moyenne an dernier"].Points.AddXY("Anglais", 14);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sélection sur les lignes
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //Seletion sur une cellule à la fois
            //textBox3.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Users selection = dataGridView2.SelectedRows[0].DataBoundItem as Users;
            textBox5.Text = selection.Utilisateur;
            textBox6.Text = selection.MotDePasse;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suppression");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("le bouton est cliqué");
        }

    }
}
