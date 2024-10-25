namespace EsercitazioneVerifica
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
            txtNome = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lstContatti = new ListBox();
            btnAggiungi = new Button();
            btnElimina = new Button();
            btnModifica = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(103, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(34, 108);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(103, 23);
            txtTelefono.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome Contatto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefono Contatto:";
            // 
            // lstContatti
            // 
            lstContatti.FormattingEnabled = true;
            lstContatti.ItemHeight = 15;
            lstContatti.Location = new Point(229, 15);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(265, 124);
            lstContatti.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(24, 178);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(140, 34);
            btnAggiungi.TabIndex = 5;
            btnAggiungi.Text = "Aggiungi Conttatto";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(191, 178);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(140, 34);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina Conttatto";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(363, 178);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(140, 34);
            btnModifica.TabIndex = 7;
            btnModifica.Text = "Modifica Conttatto";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 247);
            Controls.Add(btnModifica);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(lstContatti);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Rubrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private ListBox lstContatti;
        private Button btnAggiungi;
        private Button btnElimina;
        private Button btnModifica;
    }
}
