using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationTransform
{
    public partial class dbManage : Form
    {
        public dbManage()
        {
            InitializeComponent();
            InitializeListView();
            LoadPoints();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("序号", 50);
            listView1.Columns.Add("点名", 150);
            listView1.Columns.Add("经度", 100);
            listView1.Columns.Add("纬度", 100);
            listView1.Columns.Add("高程", 100);
            listView1.Columns.Add("备注", 150);
        }

        private void LoadPoints()
        {
            var points = pointDatas.GetPoints();
            listView1.Items.Clear();
            int index = 1;
            foreach (var point in points)
            {
                var item = new ListViewItem(index++.ToString());
                item.SubItems.Add(point.PointName);
                item.SubItems.Add(point.Longitude.ToString());
                item.SubItems.Add(point.Latitude.ToString());
                item.SubItems.Add(point.Elevation.ToString());
                item.SubItems.Add(point.Remark);
                listView1.Items.Add(item);
            }
        }

        private void refreshview_Click(object sender, EventArgs e)
        {
            LoadPoints();
        }
    }
}
