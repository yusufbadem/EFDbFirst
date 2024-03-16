namespace EFDbFirst;

partial class FrmSuppliers
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
        dgvSuppliers = new DataGridView();
        btnOrderByCompanyName = new Button();
        txtSearch = new TextBox();
        label1 = new Label();
        Take = new Label();
        txtTake = new TextBox();
        btnTake = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSuppliers.Location = new Point(5, 131);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(783, 307);
        dgvSuppliers.TabIndex = 0;
        // 
        // btnOrderByCompanyName
        // 
        btnOrderByCompanyName.Location = new Point(5, 33);
        btnOrderByCompanyName.Name = "btnOrderByCompanyName";
        btnOrderByCompanyName.Size = new Size(186, 51);
        btnOrderByCompanyName.TabIndex = 1;
        btnOrderByCompanyName.Text = "OrderByCompanyName";
        btnOrderByCompanyName.UseVisualStyleBackColor = true;
        btnOrderByCompanyName.Click += btnOrderByCompanyName_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(209, 47);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(125, 27);
        txtSearch.TabIndex = 2;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(229, 9);
        label1.Name = "label1";
        label1.Size = new Size(70, 28);
        label1.TabIndex = 3;
        label1.Text = "Search";
        // 
        // Take
        // 
        Take.AutoSize = true;
        Take.Font = new Font("Segoe UI", 12F);
        Take.Location = new Point(404, 9);
        Take.Name = "Take";
        Take.Size = new Size(50, 28);
        Take.TabIndex = 4;
        Take.Text = "Take";
        // 
        // txtTake
        // 
        txtTake.Location = new Point(368, 45);
        txtTake.Name = "txtTake";
        txtTake.Size = new Size(125, 27);
        txtTake.TabIndex = 5;
        // 
        // btnTake
        // 
        btnTake.Location = new Point(499, 43);
        btnTake.Name = "btnTake";
        btnTake.Size = new Size(95, 29);
        btnTake.TabIndex = 6;
        btnTake.Text = "btnTake";
        btnTake.UseVisualStyleBackColor = true;
        btnTake.Click += btnTake_Click;
        // 
        // FrmSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnTake);
        Controls.Add(txtTake);
        Controls.Add(Take);
        Controls.Add(label1);
        Controls.Add(txtSearch);
        Controls.Add(btnOrderByCompanyName);
        Controls.Add(dgvSuppliers);
        Name = "FrmSuppliers";
        Text = "FrmSuppliers";
        Load += FrmSuppliers_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvSuppliers;
    private Button btnOrderByCompanyName;
    private TextBox txtSearch;
    private Label label1;
    private Label Take;
    private TextBox txtTake;
    private Button btnTake;
}