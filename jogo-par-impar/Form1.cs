using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_par_impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroJogador = 0, numeroComputador = 0, total;
            // três variáveis inteiras: 'numeroJogador', 'numeroComputador' e 'total',
            // inicializando 'numeroJogador' e 'numeroComputador' com 0.

            string nome = textBoxJogador.Text;
            // uma variável string 'nome' e atribui a ela o texto inserido na caixa de texto 'txtNome'.

            Random dado = new Random();
            // Cria uma instância da classe Random para gerar números aleatórios.

            numeroComputador = dado.Next(0, 11);
            // Atribui à variável 'numeroComputador' um número aleatório entre 0 e 10

            numeroJogador = Convert.ToInt32(textBoxValor.Text);
            // Converte o texto inserido na caixa de texto 'textBoxValor' para um inteiro e atribui esse valor à variável 'numeroJogador'.

            total = (numeroComputador + numeroJogador);
            // Calcula a soma de 'numeroComputador' e 'numeroJogador' e atribui o resultado à variável 'total'.

            MessageBox.Show("Seu número " + textBoxValor + "\nNúmero do computador" + numeroComputador.ToString() + "\nTotal: " + total.ToString());

            if (radioButtonImpar.Checked == true) 
            { // Verifica se o botão de rádio 'radioButtonImpar' está marcado (o jogador escolheu ímpar).
                if (total % 2 != 0)
                {  // Verifica se o 'total' é ímpar (o resto da divisão por 2 é diferente de 0).
                    MessageBox.Show("Você escolheu ímpar. Parabéns " + nome + ", você ganhou!");
                    // Se o total for ímpar, exibe uma mensagem dizendo que o jogador ganhou.
                }
                else
                {
                    MessageBox.Show("Você escolheu ímpar. " + nome + ", você pardeu!");
                    // Se o total for par, exibe uma mensagem dizendo que o jogador perdeu.
                }
            }
            else
            {   // Se o botão de rádio 'radioButtonImpar' não estiver marcado, assume que o jogador escolheu par.
                if (total % 2 == 0) 
                { // Verifica se o 'total' é par (o resto da divisão por 2 é igual a 0).

                    MessageBox.Show("Você escolheu par. Parabéns " + nome + ", você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você escolheu par. " + nome + ", você perdeu!");
                }
            }
        }
    }
}
