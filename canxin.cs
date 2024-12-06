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
    public partial class canxin : Form
    {
        public canxin()
        {
            InitializeComponent();
        }

        private void button_f_Click(object sender, EventArgs e)
        {

            double latitude = double.Parse(Trans_B.Text);
            double longitude = double.Parse(Trans_L.Text);
            double height = double.Parse(Trans_H.Text);

            var result = GeodeticToCartesian(latitude, longitude, height);

            TransX.Text = result.x.ToString();
            TransY.Text = result.y.ToString();
            TransZ.Text = result.z.ToString();
        }

        private void button_i_Click(object sender, EventArgs e)
        {

            double x = double.Parse(TransX.Text);
            double y = double.Parse(TransY.Text);
            double z = double.Parse(TransZ.Text);

            var result = CartesianToGeodetic(x, y, z);

            Trans_B.Text = result.latitude.ToString();
            Trans_L.Text = result.longitude.ToString();
            Trans_H.Text = result.height.ToString();
        }


        private (double x, double y, double z) GeodeticToCartesian(double latitude, double longitude, double height)
        {
            // WGS84 椭球参数
            double a = 6378137.0; // 长半轴
            double f = 1 / 298.257223563; // 扁率
            double e2 = 2 * f - f * f; // 第一偏心率的平方

            // 将纬度和经度从度转换为弧度
            double latRad = latitude * Math.PI / 180.0;
            double lonRad = longitude * Math.PI / 180.0;

            // 计算N
            double N = a / Math.Sqrt(1 - e2 * Math.Sin(latRad) * Math.Sin(latRad));

            // 计算X, Y, Z
            double x = (N + height) * Math.Cos(latRad) * Math.Cos(lonRad);
            double y = (N + height) * Math.Cos(latRad) * Math.Sin(lonRad);
            double z = (N * (1 - e2) + height) * Math.Sin(latRad);

            return (x, y, z);
        }


        private (double latitude, double longitude, double height) CartesianToGeodetic(double x, double y, double z)
        {
            // WGS84 椭球参数
            double a = 6378137.0; // 长半轴
            double f = 1 / 298.257223563; // 扁率
            double e2 = 2 * f - f * f; // 第一偏心率的平方
            double b = a * (1 - f); // 短半轴

            // 计算经度
            double longitude = Math.Atan2(y, x) * 180.0 / Math.PI;

            // 迭代计算纬度和高度
            double p = Math.Sqrt(x * x + y * y);
            double theta = Math.Atan2(z * a, p * b);
            double sinTheta = Math.Sin(theta);
            double cosTheta = Math.Cos(theta);

            double latitude = Math.Atan2(z + e2 * b * sinTheta * sinTheta * sinTheta, p - e2 * a * cosTheta * cosTheta * cosTheta) * 180.0 / Math.PI;
            double N = a / Math.Sqrt(1 - e2 * Math.Sin(latitude * Math.PI / 180.0) * Math.Sin(latitude * Math.PI / 180.0));
            double height = p / Math.Cos(latitude * Math.PI / 180.0) - N;

            return (latitude, longitude, height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
