
namespace GerenciadorEtiquetas
{
    partial class EtiquetaCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtiquetaCaixa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRev = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumEtiquetas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbCodQtde = new System.Windows.Forms.PictureBox();
            this.pbCodProd = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRev);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pbCodQtde);
            this.panel2.Controls.Add(this.pbCodProd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 100);
            this.panel2.TabIndex = 56;
            // 
            // lbRev
            // 
            this.lbRev.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRev.Location = new System.Drawing.Point(730, 0);
            this.lbRev.Name = "lbRev";
            this.lbRev.Size = new System.Drawing.Size(49, 23);
            this.lbRev.TabIndex = 39;
            this.lbRev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.tbCodProduto);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbNumEtiquetas);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btImprimir);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btBuscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 270);
            this.panel4.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "© Dovale 2021 - Todos os direitos reservados.";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Location = new System.Drawing.Point(12, 28);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(97, 20);
            this.tbCodProduto.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cód do Produto";
            // 
            // tbNumEtiquetas
            // 
            this.tbNumEtiquetas.Location = new System.Drawing.Point(137, 28);
            this.tbNumEtiquetas.Name = "tbNumEtiquetas";
            this.tbNumEtiquetas.Size = new System.Drawing.Size(110, 20);
            this.tbNumEtiquetas.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "N° de Etiquetas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 95);
            this.panel1.TabIndex = 30;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(90, 57);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(41, 13);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "label13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "DESCRIÇÃO:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(68, 19);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(41, 13);
            this.lbCodigo.TabIndex = 16;
            this.lbCodigo.Text = "label13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CÓDIGO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Imagem  modelo";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorEtiquetas.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(450, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.Color.SkyBlue;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.btImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimir.Location = new System.Drawing.Point(0, 206);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(397, 40);
            this.btImprimir.TabIndex = 29;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.Location = new System.Drawing.Point(0, 59);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(397, 40);
            this.btBuscar.TabIndex = 28;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(701, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 58);
            this.button1.TabIndex = 38;
            this.button1.Text = "Voltar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(17, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(188, 62);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // pbCodQtde
            // 
            this.pbCodQtde.Location = new System.Drawing.Point(646, 0);
            this.pbCodQtde.Name = "pbCodQtde";
            this.pbCodQtde.Size = new System.Drawing.Size(31, 30);
            this.pbCodQtde.TabIndex = 36;
            this.pbCodQtde.TabStop = false;
            this.pbCodQtde.Visible = false;
            // 
            // pbCodProd
            // 
            this.pbCodProd.Location = new System.Drawing.Point(591, 0);
            this.pbCodProd.Name = "pbCodProd";
            this.pbCodProd.Size = new System.Drawing.Size(30, 30);
            this.pbCodProd.TabIndex = 34;
            this.pbCodProd.TabStop = false;
            this.pbCodProd.Visible = false;
            // 
            // EtiquetaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EtiquetaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtiquetaCaixa";
            this.Load += new System.EventHandler(this.EtiquetaCaixa_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbCodQtde;
        private System.Windows.Forms.PictureBox pbCodProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumEtiquetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}