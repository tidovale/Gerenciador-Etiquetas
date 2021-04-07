using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEtiquetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #region Botao_Fechar

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Botao Abrir_10x5
        private void Etiqueta10x5_Click(object sender, EventArgs e)
        {
            panelLeft.Height = Etiqueta10x5.Height;
            panelLeft.Top = Etiqueta10x5.Top;
            Etiqueta10x5 etiqueta10x5 = new Etiqueta10x5();
            etiqueta10x5.ShowDialog();
        }
        #endregion

        #region Botao Abrir_55x35
        private void Etiqueta55x35_Click(object sender, EventArgs e)
        {
            panelLeft.Height = Etiqueta55x35.Height;
            panelLeft.Top = Etiqueta55x35.Top;
            Etiqueta55x35 etiqueta55x35 = new Etiqueta55x35();
            etiqueta55x35.ShowDialog();
        }
        #endregion

        #region Botao Abrir_35x22 sem descricao
        private void Etiqueta35x22sem_Click(object sender, EventArgs e)
        {
            panelLeft.Height = Etiqueta35x22sem.Height;
            panelLeft.Top = Etiqueta35x22sem.Top;
            Etiqueta35x22semDescricao etiqueta35X22SemDescricao = new Etiqueta35x22semDescricao();
            etiqueta35X22SemDescricao.ShowDialog();
        }
        #endregion

        #region Botao Abrir 35x22 com descricao
        private void Etiqueta35x22Com_Click(object sender, EventArgs e)
        {
            panelLeft.Height = Etiqueta35x22Com.Height;
            panelLeft.Top = Etiqueta35x22Com.Top;
            Etiqueta35x22descricao etiqueta35X22Descricao = new Etiqueta35x22descricao();
            etiqueta35X22Descricao.ShowDialog();
        }
        #endregion

        #region Botao Abrir 55x35 com descricao
        private void Etiqueta55x35com_Click(object sender, EventArgs e)
        {
            panelLeft.Height = Etiqueta55x35com.Height;
            panelLeft.Top = Etiqueta55x35com.Top;
            Etiqueta55x35semGtin etiqueta55X35SemGtin = new Etiqueta55x35semGtin();
            etiqueta55X35SemGtin.ShowDialog();
        }
        #endregion

        #region Suporte T.I
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://192.168.10.8/glpi");
        }
        #endregion
    }
}
