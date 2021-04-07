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
    public partial class Etiqueta55x35semGtin : Form
    {
        public Etiqueta55x35semGtin()
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

        #region LimpaCampos
        private void LimpaCampos()
        {
            lbCodigo.Text = "";
            lbDescricao.Text = "";


        }
        #endregion

        #region BotaoFechar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load
        private void Etiqueta55x35semGtin_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            lbRev.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        

        }
        #endregion

        #region Buscar_Click
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
                    DataTable dtRes = new DataTable();
                    dtRes = classbd.BuscaInfoEtiqueta(tbCodProduto.Text);
                    if (dtRes.Rows.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhuma Produto com o número: " + tbCodProduto.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbCodProduto.Clear();
                        tbCodProduto.Focus();
                        LimpaCampos();
                    }
                    else
                    {
                        lbCodigo.Text = dtRes.Rows[0]["pro_codigo"].ToString();
                        lbDescricao.Text = dtRes.Rows[0]["pro_resumo"].ToString().ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Atenção: ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Imprimir_Click
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

            Font font11 = new Font("Arial", 11, FontStyle.Bold);
            Font font13 = new Font("Arial", 9, FontStyle.Bold);
            Font fontC = new Font("Arial", 20, FontStyle.Bold);
            Font fontD = new Font("Arial", 9, FontStyle.Bold);
            Font fontA = new Font("Arial", 10, FontStyle.Bold);
            Font fontZ = new Font("Arial Black", 8, FontStyle.Bold);
            Font font14 = new Font("Arial", 10, FontStyle.Bold);

            texto1 = "Código: ";
            texto2 = lbCodigo.Text;
            texto7 = "Descrição: ";
            texto8 = lbDescricao.Text;
            texto9 = "*DOVALE CHAVES*";
           


            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 0, height, width));
            //Logo lado A
            e.Graphics.DrawString(texto9, fontZ, Brushes.Black, new Rectangle(25, 20, height, width));
            //Logo lado B
            e.Graphics.DrawString(texto9, fontZ, Brushes.Black, new Rectangle(247, 20, height, width));
            // Codigo A:
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(03, 43, height, width));
            // Codigo B :
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(225, 43, height, width));
            // Nº codigo A
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(55, 41, height, width));
            // Nº codigo B
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(277, 41, height, width));
            
            //Descrição A
            e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(03, 68, 183, width));
            //Descrilão B
            e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(225, 68, 183, width));

        }
        #endregion

        private void Etiqueta55x35semGtin_Deactivate(object sender, EventArgs e)
        {
          
        }
    }
}
