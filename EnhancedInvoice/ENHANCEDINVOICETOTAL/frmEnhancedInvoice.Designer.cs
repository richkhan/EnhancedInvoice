namespace ENHANCEDINVOICETOTAL
{
    partial class frmEnhancedInvoice
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
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.RichTextBox();
            this.txtDiscountPercent = new System.Windows.Forms.RichTextBox();
            this.txtDiscountAmount = new System.Windows.Forms.RichTextBox();
            this.txtTotal = new System.Windows.Forms.RichTextBox();
            this.lblNumberOfinvoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.RichTextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.RichTextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.RichTextBox();
            this.txtNumberOfInvoices = new System.Windows.Forms.RichTextBox();
            this.txtEnterSubtotal = new System.Windows.Forms.RichTextBox();
            this.txtSmallestInvoice = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSubtotal.Location = new System.Drawing.Point(12, 39);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(170, 29);
            this.lblEnterSubtotal.TabIndex = 0;
            this.lblEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(12, 75);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(107, 29);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(12, 158);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(199, 29);
            this.lblDiscountAmount.TabIndex = 3;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.Location = new System.Drawing.Point(12, 116);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(201, 29);
            this.lblDiscountPercent.TabIndex = 2;
            this.lblDiscountPercent.Text = "Discount Percent:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 203);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 29);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(227, 75);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubtotal.Multiline = false;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(161, 34);
            this.txtSubtotal.TabIndex = 6;
            this.txtSubtotal.Text = "";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(227, 116);
            this.txtDiscountPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountPercent.Multiline = false;
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(161, 34);
            this.txtDiscountPercent.TabIndex = 7;
            this.txtDiscountPercent.Text = "";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(227, 158);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountAmount.Multiline = false;
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(161, 34);
            this.txtDiscountAmount.TabIndex = 8;
            this.txtDiscountAmount.Text = "";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(227, 203);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(161, 34);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "";
            // 
            // lblNumberOfinvoice
            // 
            this.lblNumberOfinvoice.AutoSize = true;
            this.lblNumberOfinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfinvoice.Location = new System.Drawing.Point(440, 34);
            this.lblNumberOfinvoice.Name = "lblNumberOfinvoice";
            this.lblNumberOfinvoice.Size = new System.Drawing.Size(214, 29);
            this.lblNumberOfinvoice.TabIndex = 10;
            this.lblNumberOfinvoice.Text = "Number of Invoice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total of Invoices:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Largest Invoice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Invoice Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Smallest Invoice:";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(724, 165);
            this.txtLargestInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLargestInvoice.Multiline = false;
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(161, 34);
            this.txtLargestInvoice.TabIndex = 18;
            this.txtLargestInvoice.Text = "";
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(724, 122);
            this.txtInvoiceAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceAverage.Multiline = false;
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(161, 34);
            this.txtInvoiceAverage.TabIndex = 17;
            this.txtInvoiceAverage.Text = "";
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(724, 81);
            this.txtTotalOfInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalOfInvoices.Multiline = false;
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(161, 34);
            this.txtTotalOfInvoices.TabIndex = 16;
            this.txtTotalOfInvoices.Text = "";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(724, 39);
            this.txtNumberOfInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberOfInvoices.Multiline = false;
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(161, 34);
            this.txtNumberOfInvoices.TabIndex = 15;
            this.txtNumberOfInvoices.Text = "";
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(227, 34);
            this.txtEnterSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnterSubtotal.Multiline = false;
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(161, 34);
            this.txtEnterSubtotal.TabIndex = 5;
            this.txtEnterSubtotal.Text = "";
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Location = new System.Drawing.Point(724, 203);
            this.txtSmallestInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSmallestInvoice.Multiline = false;
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(161, 34);
            this.txtSmallestInvoice.TabIndex = 19;
            this.txtSmallestInvoice.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(17, 267);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(196, 37);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(227, 267);
            this.btnClearTotals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(196, 37);
            this.btnClearTotals.TabIndex = 21;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Location = new System.Drawing.Point(445, 267);
            this.btnAboutMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(196, 37);
            this.btnAboutMe.TabIndex = 22;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 267);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 37);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEnhancedInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfinvoice);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblEnterSubtotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEnhancedInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Enhanced Invoice Total - Richard Khan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RichTextBox txtSubtotal;
        private System.Windows.Forms.RichTextBox txtDiscountPercent;
        private System.Windows.Forms.RichTextBox txtDiscountAmount;
        private System.Windows.Forms.RichTextBox txtTotal;
        private System.Windows.Forms.Label lblNumberOfinvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtLargestInvoice;
        private System.Windows.Forms.RichTextBox txtInvoiceAverage;
        private System.Windows.Forms.RichTextBox txtTotalOfInvoices;
        private System.Windows.Forms.RichTextBox txtNumberOfInvoices;
        private System.Windows.Forms.RichTextBox txtEnterSubtotal;
        private System.Windows.Forms.RichTextBox txtSmallestInvoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button btnExit;
    }
}

