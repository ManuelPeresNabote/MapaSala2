﻿
namespace MapaSala.Formularios
{
    partial class frmProfessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridProfessor = new System.Windows.Forms.DataGridView();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(233, 25);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apelido";
            // 
            // dtGridProfessor
            // 
            this.dtGridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProfessor.Location = new System.Drawing.Point(12, 87);
            this.dtGridProfessor.Name = "dtGridProfessor";
            this.dtGridProfessor.Size = new System.Drawing.Size(776, 351);
            this.dtGridProfessor.TabIndex = 6;
            this.dtGridProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProfessor_CellClick);
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(386, 22);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 7;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(495, 21);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 8;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.Location = new System.Drawing.Point(576, 21);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttExcluir.TabIndex = 9;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = true;
            this.bttExcluir.Click += new System.EventHandler(this.bttExcluir_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(657, 21);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(75, 23);
            this.bttEditar.TabIndex = 10;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.dtGridProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmProfessor";
            this.Text = "frmProfessor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridProfessor;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttEditar;
    }
}