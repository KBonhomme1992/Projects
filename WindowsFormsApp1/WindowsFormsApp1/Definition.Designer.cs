namespace WindowsFormsApp1
{
    partial class Definition
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.RichTextBox();
            this.LabelPayDate = new System.Windows.Forms.Label();
            this.TxtDue = new System.Windows.Forms.RichTextBox();
            this.LabelInvoice = new System.Windows.Forms.Label();
            this.TxtInvoice = new System.Windows.Forms.RichTextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelPayDate);
            this.groupBox1.Controls.Add(this.TxtDue);
            this.groupBox1.Controls.Add(this.LabelInvoice);
            this.groupBox1.Controls.Add(this.TxtInvoice);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 197);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definition";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(10, 77);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(37, 13);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price :";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(155, 65);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(249, 25);
            this.TxtPrice.TabIndex = 9;
            this.TxtPrice.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(155, 19);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(249, 25);
            this.TxtName.TabIndex = 7;
            this.TxtName.Text = "";
            // 
            // LabelPayDate
            // 
            this.LabelPayDate.AutoSize = true;
            this.LabelPayDate.Location = new System.Drawing.Point(10, 164);
            this.LabelPayDate.Name = "LabelPayDate";
            this.LabelPayDate.Size = new System.Drawing.Size(51, 13);
            this.LabelPayDate.TabIndex = 14;
            this.LabelPayDate.Text = "Due on : ";
            // 
            // TxtDue
            // 
            this.TxtDue.Location = new System.Drawing.Point(155, 152);
            this.TxtDue.Name = "TxtDue";
            this.TxtDue.Size = new System.Drawing.Size(249, 25);
            this.TxtDue.TabIndex = 13;
            this.TxtDue.Text = "";
            // 
            // LabelInvoice
            // 
            this.LabelInvoice.AutoSize = true;
            this.LabelInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelInvoice.Location = new System.Drawing.Point(10, 118);
            this.LabelInvoice.Name = "LabelInvoice";
            this.LabelInvoice.Size = new System.Drawing.Size(100, 13);
            this.LabelInvoice.TabIndex = 12;
            this.LabelInvoice.Text = "Invoice Ready on : ";
            // 
            // TxtInvoice
            // 
            this.TxtInvoice.Location = new System.Drawing.Point(155, 106);
            this.TxtInvoice.Name = "TxtInvoice";
            this.TxtInvoice.Size = new System.Drawing.Size(249, 25);
            this.TxtInvoice.TabIndex = 11;
            this.TxtInvoice.Text = "";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(263, 269);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 295);
            this.dataGridView1.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(982, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 295);
            this.vScrollBar1.TabIndex = 8;
            // 
            // Definition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 319);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Definition";
            this.Text = "Definition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelPayDate;
        private System.Windows.Forms.RichTextBox TxtDue;
        private System.Windows.Forms.Label LabelInvoice;
        private System.Windows.Forms.RichTextBox TxtInvoice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.RichTextBox TxtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TxtName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}