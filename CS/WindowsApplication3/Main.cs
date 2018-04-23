using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraTreeList;


namespace DXSample {
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            new DevExpress.XtraTreeList.Design.XViews(customTreeList1);
        }
    }

   
}
