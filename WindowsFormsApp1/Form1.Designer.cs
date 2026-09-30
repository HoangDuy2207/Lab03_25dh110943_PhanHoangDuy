namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnGetlnfo = new System.Windows.Forms.Button();
            this.groupBoxHost = new System.Windows.Forms.GroupBox();
            this.lblHostNameValue = new System.Windows.Forms.Label();
            this.lblIPValue = new System.Windows.Forms.Label();
            this.listViewAdapters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetlnfo
            // 
            this.btnGetlnfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGetlnfo.Location = new System.Drawing.Point(1, 1);
            this.btnGetlnfo.Name = "btnGetlnfo";
            this.btnGetlnfo.Size = new System.Drawing.Size(207, 23);
            this.btnGetlnfo.TabIndex = 0;
            this.btnGetlnfo.Text = "LẤY THÔNG TIN MẠNG";
            this.btnGetlnfo.UseVisualStyleBackColor = true;
            this.btnGetlnfo.Click += new System.EventHandler(this.btnGetlnfo_Click);
            // 
            // groupBoxHost
            // 
            this.groupBoxHost.Controls.Add(this.lblIPValue);
            this.groupBoxHost.Controls.Add(this.lblHostNameValue);
            this.groupBoxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxHost.Location = new System.Drawing.Point(12, 39);
            this.groupBoxHost.Name = "groupBoxHost";
            this.groupBoxHost.Size = new System.Drawing.Size(312, 120);
            this.groupBoxHost.TabIndex = 1;
            this.groupBoxHost.TabStop = false;
            this.groupBoxHost.Text = "THÔNG TIN HOST";
            // 
            // lblHostNameValue
            // 
            this.lblHostNameValue.AutoSize = true;
            this.lblHostNameValue.Location = new System.Drawing.Point(6, 35);
            this.lblHostNameValue.Name = "lblHostNameValue";
            this.lblHostNameValue.Size = new System.Drawing.Size(70, 17);
            this.lblHostNameValue.TabIndex = 2;
            this.lblHostNameValue.Text = "(Chưa có)";
            this.lblHostNameValue.Click += new System.EventHandler(this.lblHostNameValue_Click);
            // 
            // lblIPValue
            // 
            this.lblIPValue.AutoSize = true;
            this.lblIPValue.Location = new System.Drawing.Point(6, 68);
            this.lblIPValue.Name = "lblIPValue";
            this.lblIPValue.Size = new System.Drawing.Size(70, 17);
            this.lblIPValue.TabIndex = 4;
            this.lblIPValue.Text = "(Chưa có)";
            // 
            // listViewAdapters
            // 
            this.listViewAdapters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAdapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listViewAdapters.FullRowSelect = true;
            this.listViewAdapters.GridLines = true;
            this.listViewAdapters.HideSelection = false;
            this.listViewAdapters.Location = new System.Drawing.Point(1, 165);
            this.listViewAdapters.Name = "listViewAdapters";
            this.listViewAdapters.Size = new System.Drawing.Size(776, 195);
            this.listViewAdapters.TabIndex = 2;
            this.listViewAdapters.UseCompatibleStateImageBehavior = false;
            this.listViewAdapters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Card Mạng";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Địa Chỉ MAC";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng Thái";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ IP";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Default Gateway";
            this.columnHeader5.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewAdapters);
            this.Controls.Add(this.groupBoxHost);
            this.Controls.Add(this.btnGetlnfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHost.ResumeLayout(false);
            this.groupBoxHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetlnfo;
        private System.Windows.Forms.GroupBox groupBoxHost;
        private System.Windows.Forms.Label lblIPValue;
        private System.Windows.Forms.Label lblHostNameValue;
        private System.Windows.Forms.ListView listViewAdapters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

