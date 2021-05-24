using GenCode128;
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
    public partial class Etiqueta35x22descricao : Form
    {
        public Etiqueta35x22descricao()
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

        #region Load
        private void Etiqueta35x22descricao_Load(object sender, EventArgs e)
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
                        if (VerificaGtin(dtRes.Rows[0]["pro_barra"].ToString()))
                        {

                            lbCodigo.Text = dtRes.Rows[0]["pro_codigo"].ToString();
                            lbDescricao.Text = dtRes.Rows[0]["pro_resumo"].ToString().ToString();
                            lbGtin.Text = dtRes.Rows[0]["pro_barra"].ToString();

                            Image codbarrasCod = Code128Rendering.MakeBarcodeImage(dtRes.Rows[0]["pro_codigo"].ToString(), 2, false);
                            pbCodProd.Image = codbarrasCod;
                            pbCodProd.Image.Save(@"C:\Windows\Temp\CodProd.jpg");

                   

                            string barCode = lbGtin.Text;
                            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                            pbGtin.Image = brCode.Draw(barCode, 60);
                            pbGtin.Image.Save(@"C:\Windows\Temp\CodGtin.jpg");

                        }
                        else
                        {
                            MessageBox.Show("Este Produto não tem o código GTIN-13 válido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region VerificaGtin
        private bool VerificaGtin(string Gtin)
        {
            if (Gtin.Contains("789848864") || Gtin.Contains("789848865"))
            {
                return true;
            }
            else
            {
                return false;
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

        #region PrintDocument_Click
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Font font11 = new Font("Arial", 11, FontStyle.Bold);
            Font font13 = new Font("Arial", 7, FontStyle.Bold);
            Font fontC = new Font("Arial", 20, FontStyle.Bold);
            Font fontD = new Font("Arial", 6, FontStyle.Bold);
            Font fontA = new Font("Arial", 6, FontStyle.Bold);
            Font fontZ = new Font("Arial Black", 7, FontStyle.Bold);
            Font font14 = new Font("Arial", 8, FontStyle.Bold);

            texto1 = "Código: ";
            texto2 = lbCodigo.Text;
            texto7 = "Descrição: ";
            texto8 = lbDescricao.Text;
            texto9 = "*DOVALE CHAVES*";
            texto3 = lbGtin.Text;




            //  e.Graphics.DrawRectangl
            //  e(new Pen(Color.Black, 2), new Rectangle(0, 0, height, width));
            //  Logo lado Esquerdo

            // Codigo Lado Esquerdo
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(05, 13, height, width));
            //  Nº codigo Lado Esquerdo
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(52, 12, height, width));
            //  Descrição Lado Esquerdo
            e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(05, 25, 130, width));
            //   Cod Barras A
            Image imgCod = Image.FromFile(@"C:\Windows\Temp\CodGtin.jpg");
            e.Graphics.DrawImage(imgCod, 08, 60, 113, 20);
            imgCod.Dispose();
            //GTin
            e.Graphics.DrawString(texto3, fontA, Brushes.Black, new Rectangle(28, 79, height, width));


            // Codigo Meio
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(138, 13, height, width));
            // Nº codigo Meio
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(184, 12, height, width));
            //Descrição Meio
            e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(138, 25, 130, width));
            // Cod Barras A
            Image imgCod1 = Image.FromFile(@"C:\Windows\Temp\CodGtin.jpg");
            e.Graphics.DrawImage(imgCod1, 141, 60, 113, 20);
            imgCod1.Dispose();
            //GTin
            e.Graphics.DrawString(texto3, fontA, Brushes.Black, new Rectangle(161, 79, height, width));


            // Codigo Lado Direito
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(272, 13, height, width));
            // Nº codigo Lado Direito
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(314, 12, height, width));
            //Descrilão Lado Direito
            e.Graphics.DrawString(texto8, fontD, Brushes.Black, new Rectangle(272, 25, 130, width));
            Image imgCod2 = Image.FromFile(@"C:\Windows\Temp\CodGtin.jpg");
            e.Graphics.DrawImage(imgCod2, 275, 60, 113, 20);
            imgCod2.Dispose();
            //GTin
            e.Graphics.DrawString(texto3, fontA, Brushes.Black, new Rectangle(295, 79, height, width));


        }
        #endregion

        #region Fechar_Click
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
