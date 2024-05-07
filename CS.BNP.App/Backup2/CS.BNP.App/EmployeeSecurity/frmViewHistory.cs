using CS.BNP.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.EmployeeSecurity
{
    public partial class frmViewHistory : Form
    {
        public frmViewHistory()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var data = db.log_History.OrderByDescending(o=>o.ID).ToList();
                this.gridControl.DataSource = data;
                this.gridControl.ForceInitialize();
            }
        }
        private void frmViewHistory_Load(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
