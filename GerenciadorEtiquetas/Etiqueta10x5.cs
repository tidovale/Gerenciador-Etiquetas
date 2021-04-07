using GenCode128;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Etiqueta10x5 : Form
    {
        public Etiqueta10x5()
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





        #region LimpaCampos
        private void LimpaCampos()
        {
            lbCodigo.Text = "";
            lbDescricao.Text = "";
            lbQtde.Text = "";
            lbData.Text = "";
            tbData.Text = "";
        }
        #endregion

        #region Buscar
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
                        LimpaCampos();
                    }
                    else
                    {

                        if (VerificarTambasa().Equals(tbCodProduto.Text))
                        {
                            lbCodigo.Text = dtRes.Rows[0]["pro_codigo"].ToString();
                            lbDescricao.Text = dtRes.Rows[0]["pro_resumo"].ToString().ToString();
                            var cod10 = VerificarTambasa();
                            lbQtde.Text = tbQtde.Text;
                            lbData.Text = tbData.Text;
                            lbTambasa.Text = cod10.ToString();

                            Image codbarrasQtde = Code128Rendering.MakeBarcodeImage(lbTambasa.Text, 2, false);
                            pbCodQtde.Image = codbarrasQtde;
                            pbCodQtde.Image.Save(@"C:\Windows\Temp\CodQtde.jpg");
                            codbarrasQtde.Dispose();
                        }
                        else
                        {
                            lbCodigo.Text = dtRes.Rows[0]["pro_codigo"].ToString();
                            lbDescricao.Text = dtRes.Rows[0]["pro_resumo"].ToString().ToString();
                            lbQtde.Text = tbQtde.Text;
                            lbData.Text = tbData.Text;

                            Image codbarrasCod = Code128Rendering.MakeBarcodeImage(dtRes.Rows[0]["pro_codigo"].ToString(), 2, false);
                            pbCodProd.Image = codbarrasCod;
                            pbCodProd.Image.Save(@"C:\Windows\Temp\CodProd.jpg");
                            codbarrasCod.Dispose();

                            Image codbarrasQtde = Code128Rendering.MakeBarcodeImage(tbQtde.Text, 2, false);
                            pbCodQtde.Image = codbarrasQtde;
                            pbCodQtde.Image.Save(@"C:\Windows\Temp\CodQtde.jpg");
                            codbarrasQtde.Dispose();
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

        #region VerificarTambasa
        public long VerificarTambasa()
        {
            long cod10 = 0;
            if (tbCodProduto.Text == "17500")
            {
                cod10 = long.Parse("7898488640299");
            }
            else if (tbCodProduto.Text == "18700")
            {
                cod10 = long.Parse("7898488652360");
            }
            else if (tbCodProduto.Text == "77002")
            {

                cod10 = long.Parse("7898488640336");
            }
            else if (tbCodProduto.Text == "78400")
            {
                cod10 = long.Parse("7898488652179");
            }
            return cod10;

        }
        #endregion

        #region ExcluirImagem
        public void ExcluirImagem()
        {
            FileInfo fileOP = new FileInfo(@"C:\Windows\Temp\CodGtin.jpg");
            fileOP.Delete();
        }
        #endregion

        #region Imprimir_click
        private void btImprimir_Click_1(object sender, EventArgs e)
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
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font font11 = new Font("Arial", 11, FontStyle.Bold);
            Font font13 = new Font("Arial", 13, FontStyle.Bold);
            Font fontC = new Font("Arial", 20, FontStyle.Bold);
            Font fontD = new Font("Arial", 16, FontStyle.Bold);
            Font fontT = new Font("Arial", 9, FontStyle.Bold);

            texto1 = "Código: ";
            texto2 = lbCodigo.Text;
            texto3 = "Qtde: ";
            texto4 = lbQtde.Text;
            texto5 = "Data: ";
            texto6 = lbData.Text;
            texto7 = "Descrição: ";
            texto8 = lbDescricao.Text;
            texto9 = lbTambasa.Text;

            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 0, height, width));
            if (VerificarTambasa().Equals(tbCodProduto.Text))
            {
                //Código
                e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(25, 30, height, width));
                e.Graphics.DrawString(texto2, fontC, Brushes.Black, new Rectangle(95, 20, height, width));
                // Image imgCod = Image.FromFile(@"C:\Windows\Temp\CodProd.jpg");
                // e.Graphics.DrawImage(imgCod, 200, 10, 160, 35);
                // imgCod.Dispose();
                //Data
                e.Graphics.DrawString(texto5, font13, Brushes.Black, new Rectangle(46, 58, height, width));
                e.Graphics.DrawString(texto6, font13, Brushes.Black, new Rectangle(96, 58, height, width));

                Image img = System.Drawing.Image.FromFile("C:\\Etiqueta-Produto\\Logo.jpg");
                e.Graphics.DrawImage(img, 220, 42, 137, 23);
                img.Dispose();
                //Qtde
                e.Graphics.DrawString(texto3, font13, Brushes.Black, new Rectangle(44, 88, height, width));
                e.Graphics.DrawString(texto4, fontD, Brushes.Black, new Rectangle(92, 84, height, width));
                //Cod-Tambasa
                e.Graphics.DrawString(texto9, fontT, Brushes.Black, new Rectangle(237, 112, height, width));
                Image imgQtde = Image.FromFile(@"C:\Windows\Temp\CodQtde.jpg");
                e.Graphics.DrawImage(imgQtde, 200, 78, 160, 35);
                imgQtde.Dispose();
                //Descrição
                e.Graphics.DrawString(texto7, font13, Brushes.Black, new Rectangle(6, 130, height, width));
                e.Graphics.DrawString(texto8, font11, Brushes.Black, new Rectangle(100, 133, 285, width));
                //e.Graphics.DrawLine(new Pen(Color.Black), 20, 142, 520, 142);
            }
            else
            {
                //Código
                e.Graphics.DrawString(texto1, font13, Brushes.Black, new Rectangle(25, 30, height, width));
                e.Graphics.DrawString(texto2, fontC, Brushes.Black, new Rectangle(95, 20, height, width));
                Image imgCod = Image.FromFile(@"C:\Windows\Temp\CodProd.jpg");
                e.Graphics.DrawImage(imgCod, 200, 10, 160, 35);
                imgCod.Dispose();
                //Data
                e.Graphics.DrawString(texto5, font13, Brushes.Black, new Rectangle(46, 58, height, width));
                e.Graphics.DrawString(texto6, font13, Brushes.Black, new Rectangle(96, 58, height, width));

                Image img = System.Drawing.Image.FromFile("C:\\Etiqueta-Produto\\Logo.jpg");
                e.Graphics.DrawImage(img, 220, 57, 137, 23);
                img.Dispose();
                //Qtde
                e.Graphics.DrawString(texto3, font13, Brushes.Black, new Rectangle(44, 88, height, width));
                e.Graphics.DrawString(texto4, fontD, Brushes.Black, new Rectangle(92, 84, height, width));
                //Cod-Tambasa
                //e.Graphics.DrawString(texto9, fontT, Brushes.Black, new Rectangle(240, 122, height, width));
                Image imgQtde = Image.FromFile(@"C:\Windows\Temp\CodQtde.jpg");
                e.Graphics.DrawImage(imgQtde, 200, 88, 160, 35);
                imgQtde.Dispose();
                //Descrição
                e.Graphics.DrawString(texto7, font13, Brushes.Black, new Rectangle(6, 130, height, width));
                e.Graphics.DrawString(texto8, font11, Brushes.Black, new Rectangle(100, 133, 285, width));
                //e.Graphics.DrawLine(new Pen(Color.Black), 20, 142, 520, 142);
            }



        }
        #endregion

        #region Etiqueta10x5 Load

        private void Etiqueta10x5_Load_1(object sender, EventArgs e)
        {
            LimpaCampos();
            lbRev.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            tbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string num1 = "0";
            tbNumEtiquetas.Text = num1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Função para fechar o formulario caso clique para fora 
        private void Etiqueta10x5_Deactivate(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
