using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraTreeList;
using System.Drawing;

namespace DXSample {
    public class MyTreeList : TreeList
    {
        public MyTreeList()
            : base()
        {
            this.OptionsView.ShowIndicator = false;
            this.OptionsView.ShowFirstLines = false;
            this.OptionsView.ShowVertLines = false;
        }
        public MyTreeList(object ignore) : base(ignore) { }

        protected override TreeListViewInfo CreateViewInfo()
        {
            return new MyTreeListViewInfo(this);
        }
    }

    public class MyTreeListViewInfo : TreeListViewInfo
    {
        public MyTreeListViewInfo(MyTreeList tree)
            : base(tree)
        {

        }

        protected override void CalcRowIndentInfo(RowInfo ri) {
        }
        protected override int GetViewLevel(int level) {
            return 0;
        }
    }
}