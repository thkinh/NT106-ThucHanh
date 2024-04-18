namespace Client
{
    partial class Client
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
            Mess_box = new RichTextBox();
            Send_btn = new Button();
            Connect_btn = new Button();
            Nicknamebox = new TextBox();
            label4 = new Label();
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
            groupBox1.Size = new Size(761, 310);
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
            Chat_box.Size = new Size(749, 278);
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
            // Connect_btn
            // 
            Connect_btn.BackColor = Color.LightCoral;
            Connect_btn.Location = new Point(598, 30);
            Connect_btn.Name = "Connect_btn";
            Connect_btn.Size = new Size(175, 27);
            Connect_btn.TabIndex = 10;
            Connect_btn.Text = "Connect";
            Connect_btn.UseVisualStyleBackColor = false;
            Connect_btn.Click += Connect_btn_Click;
            // 
            // Nicknamebox
            // 
            Nicknamebox.BackColor = Color.PaleTurquoise;
            Nicknamebox.Location = new Point(406, 30);
            Nicknamebox.Name = "Nicknamebox";
            Nicknamebox.Size = new Size(158, 27);
            Nicknamebox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(406, 4);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 12;
            label4.Text = "Nickname";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Nicknamebox);
            Controls.Add(Connect_btn);
            Controls.Add(Send_btn);
            Controls.Add(Mess_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Port_box);
            Controls.Add(IP_box);
            Controls.Add(groupBox1);
            Name = "Client";
            Text = "Client";
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
        private Button Connect_btn;
        private TextBox Nicknamebox;
        private Label label4;
    }
}