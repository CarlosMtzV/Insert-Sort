namespace AlgoritmoOrderCrlos
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
            btnOrdenar = new Button();
            txtEntrada = new TextBox();
            txtSalida = new TextBox();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(162, 125);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(110, 43);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Sort";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(143, 50);
            txtEntrada.Multiline = true;
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(145, 43);
            txtEntrada.TabIndex = 1;
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(119, 210);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.Size = new Size(208, 99);
            txtSalida.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSalida);
            Controls.Add(txtEntrada);
            Controls.Add(btnOrdenar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private TextBox txtEntrada;
        private TextBox txtSalida;
    }
}
