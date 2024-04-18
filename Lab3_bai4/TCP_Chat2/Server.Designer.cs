namespace TCP_Chat2
{
    partial class Server
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
            groupBox1 = new GroupBox();
            Chat_box = new RichTextBox();
            IP_box = new TextBox();
            Port_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Start_btn = new Button();
            Mess_box = new RichTextBox();
            Send_btn = new Button();
            Clients_box = new RichTextBox();
            label3 = new Label();
            Stop_btn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGreen;
            groupBox1.Controls.Add(Chat_box);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Messages";
            // 
            // Chat_box
            // 
            Chat_box.BackColor = Color.Lavender;
            Chat_box.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Chat_box.Location = new Point(6, 26);
            Chat_box.Name = "Chat_box";
            Chat_box.Size = new Size(582, 278);
            Chat_box.TabIndex = 0;
            Chat_box.Text = "";
            // 
            // IP_box
            // 
            IP_box.BackColor = Color.PaleTurquoise;
            IP_box.Location = new Point(18, 30);
            IP_box.Name = "IP_box";
            IP_box.Size = new Size(186, 27);
            IP_box.TabIndex = 1;
            // 
            // Port_box
            // 
            Port_box.BackColor = Color.PaleTurquoise;
            Port_box.Location = new Point(240, 30);
            Port_box.Name = "Port_box";
            Port_box.Size = new Size(125, 27);
            Port_box.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(25, 23);
            label1.TabIndex = 3;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(240, 7);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // Start_btn
            // 
            Start_btn.BackColor = Color.LightCoral;
            Start_btn.Location = new Point(384, 30);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new Size(108, 27);
            Start_btn.TabIndex = 5;
            Start_btn.Text = "START";
            Start_btn.UseVisualStyleBackColor = false;
            Start_btn.Click += Start_btn_Click;
            // 
            // Mess_box
            // 
            Mess_box.BackColor = SystemColors.InactiveBorder;
            Mess_box.Location = new Point(12, 379);
            Mess_box.Name = "Mess_box";
            Mess_box.Size = new Size(594, 59);
            Mess_box.TabIndex = 6;
            Mess_box.Text = "";
            // 
            // Send_btn
            // 
            Send_btn.BackColor = Color.SteelBlue;
            Send_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Send_btn.ForeColor = Color.MidnightBlue;
            Send_btn.Location = new Point(612, 379);
            Send_btn.Name = "Send_btn";
            Send_btn.Size = new Size(161, 59);
            Send_btn.TabIndex = 7;
            Send_btn.Text = "Send";
            Send_btn.UseVisualStyleBackColor = false;
            Send_btn.Click += Send_btn_Click;
            // 
            // Clients_box
            // 
            Clients_box.BackColor = Color.PaleTurquoise;
            Clients_box.Location = new Point(631, 61);
            Clients_box.Name = "Clients_box";
            Clients_box.Size = new Size(142, 306);
            Clients_box.TabIndex = 8;
            Clients_box.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(709, 35);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 9;
            label3.Text = "Clients";
            // 
            // Stop_btn
            // 
            Stop_btn.BackColor = Color.LightCoral;
            Stop_btn.Location = new Point(498, 30);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(108, 27);
            Stop_btn.TabIndex = 10;
            Stop_btn.Text = "STOP";
            Stop_btn.UseVisualStyleBackColor = false;
            Stop_btn.Click += Stop_btn_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(Stop_btn);
            Controls.Add(label3);
            Controls.Add(Clients_box);
            Controls.Add(Send_btn);
            Controls.Add(Mess_box);
            Controls.Add(Start_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Port_box);
            Controls.Add(IP_box);
            Controls.Add(groupBox1);
            Name = "Server";
            Text = "Server";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox Chat_box;
        private TextBox IP_box;
        private TextBox Port_box;
        private Label label1;
        private Label label2;
        private Button Start_btn;
        private RichTextBox Mess_box;
        private Button Send_btn;
        private RichTextBox Clients_box;
        private Label label3;
        private Button Stop_btn;
    }
}