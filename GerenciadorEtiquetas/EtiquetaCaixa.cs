using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEtiquetas
{
    public partial class EtiquetaCaixa : Form
    {
        public EtiquetaCaixa()
        {
            InitializeComponent();
        }
        ClassBD classbd = new ClassBD();
        int height = 370;
        int width = 200;
        int cont = 0;
        string texto1;
        string texto2;
        string texto3;
        string texto4;
        string texto5;
        string texto6;
        string texto7;
        string texto8;
        string texto9;
        string texto10;

        #region Buscar Click
        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbCodProduto.Text))
                {
                    MessageBox.Show("Preencha o Cód do Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCodProduto.Focus();
                }
                else if (string.IsNullOrEmpty(tbNumEtiquetas.Text))
                {
                    MessageBox.Show("Preencha o número de Etiquetas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumEtiquetas.Focus();
                }
                else
                {
                    if (tbCodProduto.Text.Length >= 6 || tbCodProduto.Text.Length <= 1)
                    {
                        MessageBox.Show("Número inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lbCodigo.Text = tbCodProduto.Text;
                        lbDescricao.Text = DateTime.Now.ToShortDateString();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Atenção: ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load
        private void EtiquetaCaixa_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            lbRev.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        #endregion

        #region LimpaCampos
        private void LimpaCampos()
        {
            lbCodigo.Text = "";
            lbDescricao.Text = "";
        }

        #endregion

        #region Imprimir Click
        private void btImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCodigo.Text == "")
                {
                    MessageBox.Show("Não há informações para imprimir, busque um Produto primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        for (int i = 0; i < Convert.ToInt32(tbNumEtiquetas.Text); i++)
                        {
                            cont = i + 1;
                            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                            printDocument1.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção: ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region PrintDocument
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontD = new Font("Arial", 8, FontStyle.Bold);
            Font font14 = new Font("Arial", 26, FontStyle.Bold);

            texto2 = lbCodigo.Text;
            texto8 = lbDescricao.Text;

            if (tbCodProduto.Text.Length == 2)
            {
                //  Nº codigo Lado Esquerdo
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(11, 28, height, width));
                //  Descrição Lado Esquerdo
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(23, 70, 130, width));

                // Nº codigo Meio
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(144, 28, height, width));
                //Descrição Meio
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(155, 70, 130, width));

                // Nº codigo Lado Direito
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(280, 28, height, width));
                //Descrilão Lado Direito
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(285, 70, 130, width));
            }
            else if (tbCodProduto.Text.Length == 3)
            {
                //  Nº codigo Lado Esquerdo
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(16, 28, height, width));
                //  Descrição Lado Esquerdo
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(26, 70, 130, width));

                // Nº codigo Meio
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(149, 28, height, width));
                //Descrição Meio
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(159, 70, 130, width));

                // Nº codigo Lado Direito
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(285, 28, height, width));
                //Descrilão Lado Direito
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(295, 70, 130, width));
            }
            else if (tbCodProduto.Text.Length == 4)
            {
                //  Nº codigo Lado Esquerdo
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(11, 28, height, width));
                //  Descrição Lado Esquerdo
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(33, 70, 130, width));

                // Nº codigo Meio
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(144, 28, height, width));
                //Descrição Meio
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(165, 70, 130, width));

                // Nº codigo Lado Direito
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(280, 28, height, width));
                //Descrilão Lado Direito
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(295, 70, 130, width));
            }
            else if (tbCodProduto.Text.Length == 5)
            {
                //  Nº codigo Lado Esquerdo
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(11, 28, height, width));
                //  Descrição Lado Esquerdo
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(23, 70, 130, width));

                // Nº codigo Meio
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(144, 28, height, width));
                //Descrição Meio
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(155, 70, 130, width));

                // Nº codigo Lado Direito
                e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(280, 28, height, width));
                //Descrilão Lado Direito
                e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(285, 70, 130, width));
            }

        }
        #endregion

        #region Fechar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
