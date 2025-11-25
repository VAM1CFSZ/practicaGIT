namespace ejercicioTelegrama
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
            btnCalcularPrecio = new Button();
            txtPrecio = new TextBox();
            txtTelegrama = new TextBox();
            chkUrgente = new CheckBox();
            SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(245, 87);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(112, 34);
            btnCalcularPrecio.TabIndex = 0;
            btnCalcularPrecio.Text = "Calcular precio";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(245, 162);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 1;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(245, 235);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(150, 31);
            txtTelegrama.TabIndex = 2;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(248, 316);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(101, 29);
            chkUrgente.TabIndex = 3;
            chkUrgente.Text = "Urgente";
            chkUrgente.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(txtPrecio);
            Controls.Add(btnCalcularPrecio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPrecio;
        private TextBox txtPrecio;
        private TextBox txtTelegrama;
        private CheckBox chkUrgente;
    }
}
