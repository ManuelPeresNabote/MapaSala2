
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumPc = new System.Windows.Forms.NumericUpDown();
            this.txtNumCadeira = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(72, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num comp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num Cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(2, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 7;
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.Location = new System.Drawing.Point(221, 30);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(85, 17);
            this.chkIsLab.TabIndex = 8;
            this.chkIsLab.Text = "É laboratório";
            this.chkIsLab.UseVisualStyleBackColor = true;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(301, 30);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumPc
            // 
            this.txtNumPc.Location = new System.Drawing.Point(114, 29);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(41, 20);
            this.txtNumPc.TabIndex = 11;
            // 
            // txtNumCadeira
            // 
            this.txtNumCadeira.Location = new System.Drawing.Point(178, 28);
            this.txtNumCadeira.Name = "txtNumCadeira";
            this.txtNumCadeira.Size = new System.Drawing.Size(37, 20);
            this.txtNumCadeira.TabIndex = 12;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(12, 77);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 13;
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(465, 27);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 14;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.txtNumCadeira);
            this.Controls.Add(this.txtNumPc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCadeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtNumPc;
        private System.Windows.Forms.NumericUpDown txtNumCadeira;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}