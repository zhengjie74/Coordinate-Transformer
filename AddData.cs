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
    public partial class AddData : Form
    {
        public event Action<string, double, double, double> DataAdded1;

        public event Action<string, double, double, double> DataAdded2;
        public AddData()
        {
            InitializeComponent();
        }

        private int index = 0;
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_Name = comboBox1.SelectedItem.ToString();
            
            if (select_Name == "GPS经纬度坐标")
            {
                index = 1;
            }

            else if (select_Name == "GPS高斯平面坐标")
            {
                index = 2;
            }
            //MessageBox.Show(index.ToString());
        }

        private void Ipt_Add_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                MessageBox.Show("请选择坐标类型");
                return;
            }
            string pointName = Ipt_Name.Text;
            double longitude = double.Parse(Ipt_x.Text);
            double latitude = double.Parse(Ipt_y.Text);
            double elevation = double.Parse(Ipt_h.Text);
            if (index == 1)
            {
                DataAdded1?.Invoke(pointName, longitude, latitude, elevation);
            }

            else if (index == 2)
            {
                DataAdded2?.Invoke(pointName, longitude, latitude, elevation);
            }

            this.Close();
        }
    }

}
