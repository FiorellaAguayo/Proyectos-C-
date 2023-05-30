namespace Ejercicio_1
{
    partial class SayHello
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
            lblTitle = new Label();
            lblPresentation = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(23, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 22);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "¡Hola, Windows Forms!";
            // 
            // lblPresentation
            // 
            lblPresentation.AutoSize = true;
            lblPresentation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresentation.Location = new Point(23, 90);
            lblPresentation.Name = "lblPresentation";
            lblPresentation.Size = new Size(99, 21);
            lblPresentation.TabIndex = 2;
            lblPresentation.Text = "Presentacion";
            // 
            // SayHello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 167);
            Controls.Add(lblPresentation);
            Controls.Add(lblTitle);
            Name = "SayHello";
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPresentation;
    }
}