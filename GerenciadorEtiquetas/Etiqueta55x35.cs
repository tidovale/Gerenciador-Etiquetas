using GenCode128;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEtiquetas
{
    public partial class Etiqueta55x35 : Form
    {
        public Etiqueta55x35()
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
        private void Etiqueta55x35_Load(object sender, EventArgs e)
        {
            LimpaCampos();

            lbRev.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            tbQtde.Text = Convert.ToString("01");
            checkBox1.Size = new Size(150, 36);


        }
        #endregion

        #region LimpaCampos
        private void LimpaCampos()
        {
            lbCodigo.Text = "";
            lbDescricao.Text = "";
            lbGtin.Text = "";
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
                else if (string.IsNullOrEmpty(tbQtde.Text))
                {
                    MessageBox.Show("Preencha a quantidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbQtde.Focus();
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


                            Image codbarrasQtde = Code128Rendering.MakeBarcodeImage(tbQtde.Text, 2, false);
                            pbCodQtde.Image = codbarrasQtde;
                            pbCodQtde.Image.Save(@"C:\Windows\Temp\CodQtde.jpg");

                            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                            Image Gtin = brCode.Draw(dtRes.Rows[0]["pro_barra"].ToString(), 60);
                            pbGtin.Image = Gtin;
                            pbGtin.Image.Save(@"C:\Windows\Temp\CodGtin.jpg");
                            Gtin.Dispose();

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

        #region ExcluirImagem
        public void ExcluirImagem()
        {
            FileInfo fileOP = new FileInfo(@"C:\Windows\Temp\CodGtin.jpg");
            fileOP.Delete();
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

        #region  PrintDocument_Click
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font font11 = new Font("Arial", 11, FontStyle.Bold);
            Font font13 = new Font("Arial", 7, FontStyle.Bold);
            Font fontC = new Font("Arial", 20, FontStyle.Bold);
            Font fontD = new Font("Arial", 16, FontStyle.Bold);
            Font fontA = new Font("Arial", 10, FontStyle.Bold);
            Font fontZ = new Font("Arial Black", 7, FontStyle.Bold);
            Font font14 = new Font("Arial", 8, FontStyle.Bold);

            texto1 = "Código: ";
            texto2 = lbCodigo.Text;
            texto7 = "Descrição: ";
            texto8 = lbDescricao.Text;
            texto9 = "*DOVALE CHAVES*";
            texto10 = lbGtin.Text;



            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 0, height, width));
            //Logo lado A
            e.Graphics.DrawString(texto9, fontZ, Brushes.Black, new Rectangle(25, 20, height, width));
            //Logo lado B
            e.Graphics.DrawString(texto9, fontZ, Brushes.Black, new Rectangle(247, 20, height, width));
            // Codigo A:
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(05, 35, height, width));
            // Codigo B :
            e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(227, 35, height, width));
            // Nº codigo A
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(45, 34, height, width));
            // Nº codigo B
            e.Graphics.DrawString(texto2, font14, Brushes.Black, new Rectangle(267, 34, height, width));
            // Cod Barras A
            Image imgCodGtin = Image.FromFile(@"C:\Windows\Temp\CodGtin.jpg");
            e.Graphics.DrawImage(imgCodGtin, 24, 73, 113, 31);
            imgCodGtin.Dispose();
            // Cod Barras B
            Image imgCodGtin2 = Image.FromFile(@"C:\Windows\Temp\CodGtin.jpg");
            e.Graphics.DrawImage(imgCodGtin2, 244, 73, 113, 31);
            imgCodGtin2.Dispose();

            //Descrição A
            e.Graphics.DrawString(texto8, font13, Brushes.Black, new Rectangle(05, 49, 183, width));
            //Descrilão B
            e.Graphics.DrawString(texto8, font13, Brushes.Black, new Rectangle(227, 49, 183, width));
            //Gtin A
            e.Graphics.DrawString(texto10, font14, Brushes.Black, new Rectangle(41, 104, height, width));
            //Gtin B
            e.Graphics.DrawString(texto10, font14, Brushes.Black, new Rectangle(263, 104, height, width));


        }
        #endregion

        #region Button_Fechar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Etiqueta55x35_Deactivate(object sender, EventArgs e)
        {

        }
    }
}
