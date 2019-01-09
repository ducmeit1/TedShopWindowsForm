namespace Ted_Shop_System
{
    partial class CheckoutForm
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
            this.lblCheckout = new System.Windows.Forms.Label();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(66, 40);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(81, 17);
            this.lblCheckout.TabIndex = 0;
            this.lblCheckout.Text = "Order date:";
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(183, 35);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(307, 22);
            this.orderDatePicker.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(36, 91);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(111, 17);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer name:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(20, 141);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(127, 17);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.Text = "Customer address:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(31, 193);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(116, 17);
            this.lblCustomerPhone.TabIndex = 4;
            this.lblCustomerPhone.Text = "Customer phone:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(52, 243);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(95, 17);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "Total amount:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(183, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(272, 22);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(183, 138);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(272, 22);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(183, 188);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(272, 22);
            this.txtCustomerPhone.TabIndex = 8;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(183, 238);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(272, 22);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(69, 295);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(111, 41);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(522, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.lblCheckout);
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
    }
}