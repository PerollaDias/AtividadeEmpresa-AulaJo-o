using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01_Aula_João
{
    public partial class CadastroEmpresa : Form
    {

        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
                (String.IsNullOrEmpty(textBox2.Text)) ||
                (String.IsNullOrEmpty(textBox8.Text)) ||
                (String.IsNullOrEmpty(textBox9.Text)) ||
                (String.IsNullOrEmpty(textBox13.Text)) ||
                (String.IsNullOrEmpty(textBox14.Text)) ||
                (String.IsNullOrEmpty(maskedTextBox1.Text)) ||
                (String.IsNullOrEmpty(maskedTextBox2.Text)) ||
                (String.IsNullOrEmpty(maskedTextBox3.Text)) ||
                (String.IsNullOrEmpty(maskedTextBox2.Text) ||
                (String.IsNullOrEmpty(comboBox1.Text) ||
                (String.IsNullOrEmpty(comboBox2.Text) ||
                (String.IsNullOrEmpty(comboBox3.Text) ||
                (String.IsNullOrEmpty(button1.Text)))))))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Empresa novaEmpresa = new Empresa();
                {
                    novaEmpresa.nomeFantasia = textBox1.Text;
                    novaEmpresa.nomeProprietario = textBox13.Text;
                    novaEmpresa.razaoSocial = textBox2.Text;
                    novaEmpresa.cnpj = maskedTextBox1.Text;
                    novaEmpresa.situacaoCadastral = comboBox1.Text;
                    novaEmpresa.cpfProprietario = textBox14.Text;
                    novaEmpresa.telefone = maskedTextBox3.Text;
                    novaEmpresa.capitalSocial = textBox8.Text;
                    novaEmpresa.endereco = textBox9.Text;
                    novaEmpresa.estado = comboBox3.Text;
                    novaEmpresa.naturezaJuridica = comboBox2.Text;
                    novaEmpresa.porteEmpresa = groupBox3.Text;
                    novaEmpresa.tipoEmpresa = groupBox2.Text;
                    novaEmpresa.Regimetributario = groupBox1.Text;
                    novaEmpresa.datainicio = maskedTextBox2.Text;


                };
                MessageBox.Show("Empresa cadastrada com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);



                string texto = @"C:\Users\2022102020078\Desktop\atividadeJoão.Atividade01.txt";
                using (StreamWriter sw = new StreamWriter(texto))
                {
                    sw.WriteLine(MessageBox.Show($"CNPJ = {maskedTextBox1.Text}\n" +
                        $"Razão Social:{textBox2.Text}\n" + $"Nome Fatasia:{textBox1.Text}\n"
                        + $"Situação:{comboBox1.Text}\n" +
                $"Regime Tributário:{groupBox1.Text}\n" +
                $"Data de iníco:{maskedTextBox2.Text}\n" + $"Telefone:{maskedTextBox3.Text}\n"
                + $"Capital:{textBox8.Text}\n" +
                 $"Endereço:{textBox9.Text}\n" + $"Tipo:{groupBox2.Text}\n" +
                 $"Porte da Empresa:{groupBox3.Text}\n" + $"Juridica:{comboBox2.Text}\n"
                 + $"Proprietário:{textBox13.Text}\n" + $"Cpf do proprietário{textBox14.Text}\n"));
                }


            }

        }

        private void Verificar_Click(object sender, EventArgs e)
        {


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Console.WriteLine("RadioButton 6 está marcado.");
            }
            else if (radioButton7.Checked)
            {
                Console.WriteLine("RadioButton 7 está marcado.");
            }
            else if (radioButton8.Checked)
            {
                Console.WriteLine("RadioButton 8 está marcado.");
            }
            else
            {
                Console.WriteLine("Nenhum RadioButton está marcado.");
            }
            //NÃO DEU CERTO A VERIFICAÇÃO!!!
        }
    }
}
