
namespace Lab7_Advanced_Command
{
    partial class OrdersForm
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
            this.tsSummary = new System.Windows.Forms.ToolStrip();
            this.tsrSummary = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.tsSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSummary
            // 
            this.tsSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSummary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrSummary});
            this.tsSummary.Location = new System.Drawing.Point(0, 469);
            this.tsSummary.Name = "tsSummary";
            this.tsSummary.Size = new System.Drawing.Size(1023, 25);
            this.tsSummary.TabIndex = 6;
            this.tsSummary.Text = "Tổng doanh thu trong ngày là:";
            // 
            // tsrSummary
            // 
            this.tsrSummary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsrSummary.Name = "tsrSummary";
            this.tsrSummary.Size = new System.Drawing.Size(234, 22);
            this.tsrSummary.Text = "Tổng doanh thu trong ngày là:";
            this.tsrSummary.Click += new System.EventHandler(this.tsrSummary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn ngày:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "        MM/dd/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(461, 8);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(234, 27);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgv_bills
            // 
            this.dgv_bills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.Location = new System.Drawing.Point(13, 41);
            this.dgv_bills.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.Size = new System.Drawing.Size(997, 422);
            this.dgv_bills.TabIndex = 7;
            this.dgv_bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellContentClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 494);
            this.Controls.Add(this.tsSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgv_bills);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.tsSummary.ResumeLayout(false);
            this.tsSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSummary;
        private System.Windows.Forms.ToolStripLabel tsrSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgv_bills;
    }
}