namespace Ted_Shop_System
{
    partial class CartForm
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(22, 13);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 39);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Location = new System.Drawing.Point(22, 75);
            this.cartDataGridView.MultiSelect = false;
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowTemplate.Height = 24;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(1148, 403);
            this.cartDataGridView.TabIndex = 1;
            this.cartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 508);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.btnCheckout);
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView cartDataGridView;
    }
}