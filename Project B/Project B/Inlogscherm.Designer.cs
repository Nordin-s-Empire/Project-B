namespace Project_B
{
    partial class Inlogscherm
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
            this.Terugknop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Terugknop
            // 
            this.Terugknop.Location = new System.Drawing.Point(37, 27);
            this.Terugknop.Name = "Terugknop";
            this.Terugknop.Size = new System.Drawing.Size(89, 35);
            this.Terugknop.TabIndex = 0;
            this.Terugknop.Text = "Terug";
            this.Terugknop.UseVisualStyleBackColor = true;
            this.Terugknop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Terugklik);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(675, 499);
            this.Controls.Add(this.Terugknop);
            this.Name = "Inlogscherm";
            this.Text = "Inlogscherm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Terugknop;
    }
}