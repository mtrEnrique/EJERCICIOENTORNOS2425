namespace WinFormsApp1
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
            chkUrgente = new CheckBox();
            button1 = new Button();
            txtTelegrama = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(73, 331);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(78, 19);
            chkUrgente.TabIndex = 0;
            chkUrgente.Text = "¿Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(617, 362);
            button1.Name = "button1";
            button1.Size = new Size(113, 36);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcularPrecio_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(121, 93);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(549, 208);
            txtTelegrama.TabIndex = 2;
            txtTelegrama.TextChanged += btnCalcularPrecio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Texto:";
            label1.Click += label1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(121, 370);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 373);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Coste:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(txtTelegrama);
            Controls.Add(button1);
            Controls.Add(chkUrgente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkUrgente;
        private Button button1;
        private TextBox txtTelegrama;
        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
    }
}
