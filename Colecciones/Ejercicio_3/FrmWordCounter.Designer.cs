namespace Ejercicio_3
{
    partial class FrmWordCounter
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
            rtxtWordCounter = new RichTextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // rtxtWordCounter
            // 
            rtxtWordCounter.Location = new Point(73, 37);
            rtxtWordCounter.Name = "rtxtWordCounter";
            rtxtWordCounter.Size = new Size(339, 374);
            rtxtWordCounter.TabIndex = 0;
            rtxtWordCounter.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(571, 375);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 43);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // FrmWordCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(rtxtWordCounter);
            Name = "FrmWordCounter";
            Text = "Contador de Palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxtWordCounter;
        private Button btnCalculate;
    }
}