using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Matriz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i, j;
            string[,] nomes = new string[,] { { "João", "Antonio" }, { "Maria", "Ana" } };

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    listBox1.Items.Add(nomes[i, j]);
                }
            }
        }
    }
}
