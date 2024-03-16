using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst;
public partial class FrmSuppliers : Form
{
    public FrmSuppliers()
    {
        InitializeComponent();
    }

    private void FrmSuppliers_Load(object sender, EventArgs e)
    {
        GetAllSuppliers();
    }

    void GetAllSuppliers()
    {
        NorthwindContext db = new NorthwindContext();

        var suppliers = db.Suppliers.ToList();

        dgvSuppliers.DataSource = suppliers;


    }

    private void btnOrderByCompanyName_Click(object sender, EventArgs e)
    {
        NorthwindContext db = new NorthwindContext();

        var suppliers = db.Suppliers.OrderBy(x => x.CompanyName).ToList();
        dgvSuppliers.DataSource = suppliers;
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        NorthwindContext db = new NorthwindContext();

        var Search = txtSearch.Text;

        var suppliers = db.Suppliers.Where(x => x.CompanyName.StartsWith(Search)).ToList();

        dgvSuppliers.DataSource = suppliers;
    }

    private void btnTake_Click(object sender, EventArgs e)
    {
        NorthwindContext db=new NorthwindContext();
        int TakeNum =Convert.ToInt32(txtTake.Text);

        var suppliers=db.Suppliers.Take(TakeNum).ToList();
        dgvSuppliers.DataSource = suppliers;
    }
}
