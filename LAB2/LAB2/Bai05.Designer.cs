namespace LAB2
{
    partial class Bai05
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
            Files_list = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // Files_list
            // 
            Files_list.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Files_list.Location = new Point(0, 0);
            Files_list.Name = "Files_list";
            Files_list.Size = new Size(963, 510);
            Files_list.TabIndex = 0;
            Files_list.UseCompatibleStateImageBehavior = false;
            Files_list.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên File";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kích thước";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đuôi mở rộng";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày tạo";
            columnHeader4.Width = 400;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 507);
            Controls.Add(Files_list);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
        }

        #endregion

        private ListView Files_list;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}