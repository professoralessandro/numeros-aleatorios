
namespace SorteioAleatorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxParticipantes = new System.Windows.Forms.ListBox();
            this.BtnAddParticipante = new System.Windows.Forms.Button();
            this.TxtAddParticipante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimparParticipantes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSortearGanhador = new System.Windows.Forms.Button();
            this.BtnLimparGanhadores = new System.Windows.Forms.Button();
            this.ListBoxGanhadores = new System.Windows.Forms.ListBox();
            this.LabelGanhador = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxParticipantes
            // 
            this.listBoxParticipantes.FormattingEnabled = true;
            this.listBoxParticipantes.ItemHeight = 15;
            this.listBoxParticipantes.Location = new System.Drawing.Point(6, 22);
            this.listBoxParticipantes.Name = "listBoxParticipantes";
            this.listBoxParticipantes.Size = new System.Drawing.Size(393, 394);
            this.listBoxParticipantes.TabIndex = 0;
            // 
            // BtnAddParticipante
            // 
            this.BtnAddParticipante.Location = new System.Drawing.Point(6, 451);
            this.BtnAddParticipante.Name = "BtnAddParticipante";
            this.BtnAddParticipante.Size = new System.Drawing.Size(190, 28);
            this.BtnAddParticipante.TabIndex = 1;
            this.BtnAddParticipante.Text = "Adicionar Participante";
            this.BtnAddParticipante.UseVisualStyleBackColor = true;
            this.BtnAddParticipante.Click += new System.EventHandler(this.BtnAddParticipante_Click);
            // 
            // TxtAddParticipante
            // 
            this.TxtAddParticipante.Location = new System.Drawing.Point(6, 422);
            this.TxtAddParticipante.Name = "TxtAddParticipante";
            this.TxtAddParticipante.Size = new System.Drawing.Size(393, 23);
            this.TxtAddParticipante.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimparParticipantes);
            this.groupBox1.Controls.Add(this.listBoxParticipantes);
            this.groupBox1.Controls.Add(this.BtnAddParticipante);
            this.groupBox1.Controls.Add(this.TxtAddParticipante);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 491);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participantes";
            // 
            // BtnLimparParticipantes
            // 
            this.BtnLimparParticipantes.Location = new System.Drawing.Point(202, 451);
            this.BtnLimparParticipantes.Name = "BtnLimparParticipantes";
            this.BtnLimparParticipantes.Size = new System.Drawing.Size(197, 28);
            this.BtnLimparParticipantes.TabIndex = 3;
            this.BtnLimparParticipantes.Text = "Limpar Participantes";
            this.BtnLimparParticipantes.UseVisualStyleBackColor = true;
            this.BtnLimparParticipantes.Click += new System.EventHandler(this.BtnLimparParticipantes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSortearGanhador);
            this.groupBox2.Controls.Add(this.BtnLimparGanhadores);
            this.groupBox2.Controls.Add(this.ListBoxGanhadores);
            this.groupBox2.Location = new System.Drawing.Point(698, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 491);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ganhadores";
            // 
            // BtnSortearGanhador
            // 
            this.BtnSortearGanhador.Location = new System.Drawing.Point(6, 452);
            this.BtnSortearGanhador.Name = "BtnSortearGanhador";
            this.BtnSortearGanhador.Size = new System.Drawing.Size(194, 28);
            this.BtnSortearGanhador.TabIndex = 4;
            this.BtnSortearGanhador.Text = "Sortear";
            this.BtnSortearGanhador.UseVisualStyleBackColor = true;
            this.BtnSortearGanhador.Click += new System.EventHandler(this.BtnSortearGanhador_Click);
            // 
            // BtnLimparGanhadores
            // 
            this.BtnLimparGanhadores.Location = new System.Drawing.Point(206, 452);
            this.BtnLimparGanhadores.Name = "BtnLimparGanhadores";
            this.BtnLimparGanhadores.Size = new System.Drawing.Size(193, 28);
            this.BtnLimparGanhadores.TabIndex = 3;
            this.BtnLimparGanhadores.Text = "Limpar Ganhadores";
            this.BtnLimparGanhadores.UseVisualStyleBackColor = true;
            this.BtnLimparGanhadores.Click += new System.EventHandler(this.BtnLimparGanhadores_Click);
            // 
            // ListBoxGanhadores
            // 
            this.ListBoxGanhadores.FormattingEnabled = true;
            this.ListBoxGanhadores.ItemHeight = 15;
            this.ListBoxGanhadores.Location = new System.Drawing.Point(6, 21);
            this.ListBoxGanhadores.Name = "ListBoxGanhadores";
            this.ListBoxGanhadores.Size = new System.Drawing.Size(393, 424);
            this.ListBoxGanhadores.TabIndex = 0;
            // 
            // LabelGanhador
            // 
            this.LabelGanhador.AutoSize = true;
            this.LabelGanhador.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelGanhador.Location = new System.Drawing.Point(448, 77);
            this.LabelGanhador.Name = "LabelGanhador";
            this.LabelGanhador.Size = new System.Drawing.Size(113, 30);
            this.LabelGanhador.TabIndex = 5;
            this.LabelGanhador.Text = "Ganhador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 575);
            this.Controls.Add(this.LabelGanhador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxParticipantes;
        private System.Windows.Forms.Button BtnAddParticipante;
        private System.Windows.Forms.TextBox TxtAddParticipante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLimparParticipantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnLimparGanhadores;
        private System.Windows.Forms.ListBox ListBoxGanhadores;
        private System.Windows.Forms.Label LabelGanhador;
        private System.Windows.Forms.Button BtnSortearGanhador;
    }
}

