namespace LAB2
{
    partial class MENU
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
            Bai4 = new Button();
            Bai5 = new Button();
            SuspendLayout();
            // 
            // Bai4
            // 
            Bai4.Location = new Point(93, 108);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(245, 151);
            Bai4.TabIndex = 0;
            Bai4.Text = "BAI 04";
            Bai4.UseVisualStyleBackColor = true;
            Bai4.Click += Bai4_Click;
            // 
            // Bai5
            // 
            Bai5.Location = new Point(446, 108);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(244, 151);
            Bai5.TabIndex = 1;
            Bai5.Text = "BAI 05";
            Bai5.UseVisualStyleBackColor = true;
            Bai5.Click += Bai5_Click;
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Name = "MENU";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai4;
        private Button Bai5;
    }
}