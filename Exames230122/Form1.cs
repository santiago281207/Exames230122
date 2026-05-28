using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exames230122
{
    public partial class Form1 : Form
    {
        Exame exame = new Exame("RC");
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9');
        }

        private void btnPresenca_Click(object sender, EventArgs e)
        {
            if (txtAluno.Text == String.Empty)
            {
                MessageBox.Show("Precisa de existir texto no campo 'aluno'!", "Erro", MessageBoxButtons.OK);
                return;
            }
            DateTime data = dtpData.Value.Date;
            int numero = int.Parse(txtAluno.Text);

            int num;
            DateTime date;

            if(exame.CheckRepetido(numero,data))
            {
                MessageBox.Show("Esse aluno já tem uma inscrição nessa data!", "Erro", MessageBoxButtons.OK);
            }else if(exame.Quantidade-1 < exame.Dimensao)
            {
                exame.Add(numero, data);
                exame.GetIndexValues(exame.Quantidade-1, out num, out date);
                string frase = $"{num} -> {date.ToShortDateString()}";
                ltbRegistos.Items.Add(frase);
            }else
            {
                MessageBox.Show("Já não existem vagas!", "Erro", MessageBoxButtons.OK);
            }
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            DateTime data = dtpData.Value.Date;
            int n;
            string disciplina = exame.Sigla;

            n = exame.AlunosPorData(data);
            MessageBox.Show($"No dia {data} existiram {n} alunos na AE de {disciplina}");

        }
    }
}
