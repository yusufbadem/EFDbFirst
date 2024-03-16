namespace EFDbFirst;

partial class FrmOneSupplier
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
        lblasd = new Label();
        txtId = new TextBox();
        btnGetir = new Button();
        lbl1 = new Label();
        lblasdas = new Label();
        label4 = new Label();
        lblCompanyName = new Label();
        lblContatctName = new Label();
        lblContactTitle = new Label();
        SuspendLayout();
        // 
        // lblasd
        // 
        lblasd.AutoSize = true;
        lblasd.Location = new Point(170, 35);
        lblasd.Name = "lblasd";
        lblasd.Size = new Size(24, 20);
        lblasd.TabIndex = 0;
        lblasd.Text = "ID";
        // 
        // txtId
        // 
        txtId.Location = new Point(239, 32);
        txtId.Name = "txtId";
        txtId.Size = new Size(125, 27);
        txtId.TabIndex = 1;
        // 
        // btnGetir
        // 
        btnGetir.Location = new Point(241, 81);
        btnGetir.Name = "btnGetir";
        btnGetir.Size = new Size(123, 29);
        btnGetir.TabIndex = 2;
        btnGetir.Text = "btnGetir";
        btnGetir.UseVisualStyleBackColor = true;
        btnGetir.Click += btnGetir_Click;
        // 
        // lbl1
        // 
        lbl1.AutoSize = true;
        lbl1.Font = new Font("Segoe UI", 12F);
        lbl1.Location = new Point(178, 174);
        lbl1.Name = "lbl1";
        lbl1.Size = new Size(153, 28);
        lbl1.TabIndex = 3;
        lbl1.Text = "Company Name";
        // 
        // lblasdas
        // 
        lblasdas.AutoSize = true;
        lblasdas.Font = new Font("Segoe UI", 12F);
        lblasdas.Location = new Point(178, 227);
        lblasdas.Name = "lblasdas";
        lblasdas.Size = new Size(137, 28);
        lblasdas.TabIndex = 4;
        lblasdas.Text = "Contact Name";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(178, 276);
        label4.Name = "label4";
        label4.Size = new Size(122, 28);
        label4.TabIndex = 5;
        label4.Text = "Contact Title";
        // 
        // lblCompanyName
        // 
        lblCompanyName.AutoSize = true;
        lblCompanyName.Font = new Font("Segoe UI", 12F);
        lblCompanyName.Location = new Point(354, 174);
        lblCompanyName.Name = "lblCompanyName";
        lblCompanyName.Size = new Size(23, 28);
        lblCompanyName.TabIndex = 6;
        lblCompanyName.Text = "0";
        // 
        // lblContatctName
        // 
        lblContatctName.AutoSize = true;
        lblContatctName.Font = new Font("Segoe UI", 12F);
        lblContatctName.Location = new Point(354, 227);
        lblContatctName.Name = "lblContatctName";
        lblContatctName.Size = new Size(23, 28);
        lblContatctName.TabIndex = 7;
        lblContatctName.Text = "0";
        // 
        // lblContactTitle
        // 
        lblContactTitle.AutoSize = true;
        lblContactTitle.Font = new Font("Segoe UI", 12F);
        lblContactTitle.Location = new Point(354, 276);
        lblContactTitle.Name = "lblContactTitle";
        lblContactTitle.Size = new Size(23, 28);
        lblContactTitle.TabIndex = 8;
        lblContactTitle.Text = "0";
        // 
        // FrmOneSupplier
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblContactTitle);
        Controls.Add(lblContatctName);
        Controls.Add(lblCompanyName);
        Controls.Add(label4);
        Controls.Add(lblasdas);
        Controls.Add(lbl1);
        Controls.Add(btnGetir);
        Controls.Add(txtId);
        Controls.Add(lblasd);
        Name = "FrmOneSupplier";
        Text = "FrmOneSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblasd;
    private TextBox txtId;
    private Button btnGetir;
    private Label lbl1;
    private Label lblasdas;
    private Label label4;
    private Label lblCompanyName;
    private Label lblContatctName;
    private Label lblContactTitle;
}