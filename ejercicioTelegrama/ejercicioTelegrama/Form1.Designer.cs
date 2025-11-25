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
            rbOrdinario = new RadioButton();
            rbUrgente = new RadioButton();
            lblResultado = new Label();
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
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Checked = true;
            rbOrdinario.Location = new Point(254, 299);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(112, 29);
            rbOrdinario.TabIndex = 3;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(254, 343);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(100, 29);
            rbUrgente.TabIndex = 4;
            rbUrgente.TabStop = true;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(517, 198);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
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
        private RadioButton rbOrdinario;
        private RadioButton rbUrgente;
        private Label lblResultado;
    }
}
