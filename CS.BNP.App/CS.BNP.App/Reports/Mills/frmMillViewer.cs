using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Reports.Mills
{
    public partial class frmMillViewer : Form
    {
        public frmMillViewer()
        {
            InitializeComponent();
        }
          public int keyId = 0; public int secondKeyId = 0;
        public int[] tranCreditorId; public DateTime dtStart; public DateTime dtEnd;
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
    }
}
