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
public partial class FrmOneSupplier : Form
{
    public FrmOneSupplier()
    {
        InitializeComponent();
    }

    private void btnGetir_Click(object sender, EventArgs e)
    {
        int IdGetir=Convert.ToInt32(txtId.Text);

        NorthwindContext db= new NorthwindContext();

        Supplier supplier=db.Suppliers.FirstOrDefault(x=>x.SupplierId==IdGetir);

        if (supplier==null)
        {
            MessageBox.Show("Supplier Not Found");
            return;
        }
        lblCompanyName.Text= supplier.CompanyName;
        lblContatctName.Text = supplier.ContactName;
        lblContactTitle.Text= supplier.ContactTitle;


        
    }
}
