using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrinhoComprasT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //vetor para os produtos
        public string[] produtos = new string[9];
        
        //vetor para os preços
        public decimal[] precos = new decimal[9] { 150, 12, 5.90M, 123.4M, 99.99M, 97.99M, 2.34M, 150, 320 };


        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            comboBox1.Items.Add("Hardware");
            comboBox1.Items.Add("Software");
            lstProdutos.Items.Clear();

            lstCarrinho.BackColor = SystemColors.InactiveBorder;

            lblErro.Visible = false;

            produtos[0] = "Monitor";
            produtos[1] = "Teclado";
            produtos[2] = "Rato";
            produtos[3] = "Impressora";
            produtos[4] = "Windows 10";
            produtos[5] = "Windows 11";
            produtos[6] = "Linux Ubuntu";
            produtos[7] = "Office 2022";
            produtos[8] = "Visual Studio 2022 Enterprise";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Text = "Categoria de produtos:";

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            int pos = comboBox1.SelectedIndex;   //-1 vazio sem escolha
            if (pos == -1)
            {
               /*
                MessageBox.Show("Escolha uma categoria de produtos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
               */
                lblCategoria.ForeColor = Color.Red;
                lblCategoria.Text = "Escolha uma categoria!";
                return;
            }
            else 
            {
                //escolheu um categoria
                /*
                if (comboBox1.SelectedItem.Equals("Hardware")) 
                {
                    MessageBox.Show(comboBox1.SelectedItem.ToString());
                }
                */

                //escolheu Hardware
                if (pos == 0)
                {
                    lstProdutos.Items.Clear();
                    lstProdutos.Items.Add("Monitor\t250€");
                    lstProdutos.Items.Add("Teclado\t15€");
                    lstProdutos.Items.Add("Rato");
                    lstProdutos.Items.Add("Impressora");
                }
                else
                //escolheu Software
                {
                    lstProdutos.Items.Clear();
                    lstProdutos.Items.Add("Windows 10");
                    lstProdutos.Items.Add("Windows 11");
                    lstProdutos.Items.Add("Linux Ubuntu");
                    lstProdutos.Items.Add("Office 2022");
                    lstProdutos.Items.Add("Visual Studio 2022 Enterprise");
                }
            }
        }



        private void lblErro_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Nenhum produto selecionado para o carrinho.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstProdutos_MouseEnter(object sender, EventArgs e)
        {
            lblErro.Visible = false;

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem != null)
            {
                //escolheu um produto
                lstCarrinho.Enabled = true;
                lstCarrinho.BackColor = SystemColors.Window;
                lstCarrinho.Items.Add(lstProdutos.SelectedItem);
                lstProdutos.SelectedIndex = -1;
            }
            else
            //não escolheu qualquer produto
            {
                //não escolheu a categoria
                if (comboBox1.SelectedIndex == -1)
                {
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Escolha uma categoria!";
                    comboBox1.Focus();
                }
                else
                {
                    //escolheu categoria mas nao escolheu produto
                    lblErro.Visible = true;
                }
            }

        }

        private void btnRemoverUm_Click(object sender, EventArgs e)
        {
            //verificar se tem produtos para remover
            if (lstCarrinho.SelectedIndex > -1)
            {
                int pos = lstCarrinho.SelectedIndex;
                lstCarrinho.Items.RemoveAt(pos);
            }
        }

        private void btnRemoverTudo_Click(object sender, EventArgs e)
        {
            if (lstCarrinho.Items.Count == 0) return;

            DialogResult resposta = new DialogResult();
            string _msg = "Esta operação elimina o seu carrinho.\nTem a certeza que quer eliminar tudo?";
            string _titulo = "Remover tudo";
            var _botoes = MessageBoxButtons.YesNo;
            var _icone = MessageBoxIcon.Question;

            resposta = MessageBox.Show(_msg, _titulo, _botoes, _icone);

            if (resposta==DialogResult.Yes)
            {
                lstCarrinho.Items.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar os produtos e calcular o preço total
            int nitens = lstCarrinho.Items.Count;
            decimal totalCarrinho = 0;

            if (nitens == 0)
            {
                MessageBox.Show("Não tem nada no carrinho de compras.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //percorrer o carrinho para saber qual o preço de cada produto
            for (int i = 0; i < nitens; i++)
            {
                //obter o nome do produto
                string produtoNome = lstCarrinho.Items[i].ToString();

                //percorrer o vetor de produtos
                for (int j=0; j < 9; j++)
                {
                    //verificar se é o produto do carrinho
                    if (produtoNome.Equals(produtos[j]))
                    {
                        totalCarrinho = totalCarrinho + precos[j];
                        label1.Text = totalCarrinho.ToString();
                        break;
                    }
                }
            }

            MessageBox.Show("Total no carrinho de compras: " + totalCarrinho.ToString(), 
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
