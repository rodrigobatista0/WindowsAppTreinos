using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinosJC
{
    public partial class FormDetalhes : Form
    {
        public int NumeroTreinos
        { get; private set;}

        public FormDetalhes()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtInfo.Text, out int n) && n > 0)
            {
                NumeroTreinos = n;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduz um número válido maior que zero!", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
