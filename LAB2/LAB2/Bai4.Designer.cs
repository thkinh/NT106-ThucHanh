namespace LAB2
{
    partial class Bai4
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
            ReadButton = new Button();
            Data = new RichTextBox();
            WriteButton = new Button();
            Write_Input_btn = new Button();
            Exit_btn = new Button();
            SuspendLayout();
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(30, 131);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(192, 69);
            ReadButton.TabIndex = 0;
            ReadButton.Text = "Đọc input.txt";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // Data
            // 
            Data.Location = new Point(314, 33);
            Data.Name = "Data";
            Data.Size = new Size(453, 379);
            Data.TabIndex = 1;
            Data.Text = "";
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(30, 232);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(192, 69);
            WriteButton.TabIndex = 2;
            WriteButton.Text = "Xuất output.txt";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // Write_Input_btn
            // 
            Write_Input_btn.Location = new Point(30, 33);
            Write_Input_btn.Name = "Write_Input_btn";
            Write_Input_btn.Size = new Size(192, 69);
            Write_Input_btn.TabIndex = 3;
            Write_Input_btn.Text = "Ghi xuống input.txt";
            Write_Input_btn.UseVisualStyleBackColor = true;
            Write_Input_btn.Click += Write_Input_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(30, 343);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(192, 69);
            Exit_btn.TabIndex = 4;
            Exit_btn.Text = "Thoát";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit_btn);
            Controls.Add(Write_Input_btn);
            Controls.Add(WriteButton);
            Controls.Add(Data);
            Controls.Add(ReadButton);
            Name = "Bai4";
            Text = "Bài 4";
            ResumeLayout(false);
        }

        #endregion

        private Button ReadButton;
        private RichTextBox Data;
        private Button WriteButton;
        private Button Write_Input_btn;
        private Button Exit_btn;
    }
}