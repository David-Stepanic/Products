namespace GUI
{
    partial class ProductsForm
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
            label1 = new Label();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDelete = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(800, 23);
            label1.TabIndex = 0;
            label1.Text = "List Of Products";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(28, 61);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(118, 23);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProduct.Location = new Point(618, 61);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(100, 23);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(737, 61);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(28, 107);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(784, 318);
            dgv.TabIndex = 4;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(dgv);
            Controls.Add(btnDelete);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(label1);
            Name = "ProductsForm";
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddProduct;
        private Button btnEditProduct;
        private Button btnDelete;
        private DataGridView dgv;
    }
}