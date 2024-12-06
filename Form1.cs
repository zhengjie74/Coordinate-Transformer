using Microsoft.VisualBasic;
using static LocationTransform.Storage;

namespace LocationTransform
{
    public partial class Form1 : Form
    {
        private List<Coordinate> coordinates = new List<Coordinate>();
        private List<Spheroid> spheroids = new List<Spheroid>();
        private List<Location> locations = new List<Location>();

        public Form1()
        {
            InitializeComponent();
            // 初始化数据库
            //pointDatas.InitializeDatabase();
            // 绑定右键菜单事件
            listView1.MouseUp += ListView1_MouseUp;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 绑定选中项改变事件
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            //绑定 ComBox 事件
            comboBox_Ellipsoid.SelectedIndexChanged += ComboBox_Ellipsoid_SelectedIndexChanged;
            //初始化椭球
            InitializeSpheroids();
            //初始化椭球下拉框
            foreach (Spheroid spheroid in spheroids)
            {
                comboBox_Ellipsoid.Items.Add(spheroid.Name);
            }
            // 加载数据库中的点数据

            LoadPointsFromDatabase();
        }

        private void InitializeSpheroids()
        {
            spheroids.Add(new Spheroid("WGS-84", 6378137.0, 6356752.3142));
            spheroids.Add(new Spheroid("CGCS2000", 6378137.0, 6356752.3141));
            spheroids.Add(new Spheroid("Xian 1980", 6378140.0, 6356755.2882));
            spheroids.Add(new Spheroid("Beijing 1954", 6378245.0, 6356863.0188));
            spheroids.Add(new Spheroid("Xian 1980 3 Degree GK Zone 25", 6378140.0, 6356755.2882));
            spheroids.Add(new Spheroid("Beijing 1954 3 Degree GK Zone 25", 6378245.0, 6356863.0188));
            spheroids.Add(new Spheroid("Krassovsky ellipsoid", 6378245.0, 6356863.0187));
            spheroids.Add(new Spheroid("Bessel ellipsoid", 6377397, 6356075.0441));
        }

        private void LoadPointsFromDatabase()
        {
            coordinates = pointDatas.GetPoints();
            UpdateListView1();
        }

        private void button_ImportFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (string line in lines.Skip(1)) // 跳过标题行
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            string pointName = parts[0];
                            double longitude = double.Parse(parts[1]);
                            double latitude = double.Parse(parts[2]);
                            double elevation = double.Parse(parts[3]);
                            string remark = parts[4];

                            Coordinate coordinate = new Coordinate(pointName, longitude, latitude, elevation, remark);
                            coordinates.Add(coordinate);
                            pointDatas.AddPoint(coordinate);
                        }
                    }

                    UpdateListView1();
                }
            }
        }

        private void UpdateListView1()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            int index = 1;
            foreach (Coordinate coordinate in coordinates)
            {
                ListViewItem item = new ListViewItem(index++.ToString());
                item.SubItems.Add(coordinate.PointName);
                item.SubItems.Add(coordinate.Longitude.ToString());
                item.SubItems.Add(coordinate.Latitude.ToString());
                item.SubItems.Add(coordinate.Elevation.ToString());
                item.SubItems.Add(coordinate.Remark);
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void UpdateListView2()
        {
            listView2.BeginUpdate();
            listView2.Items.Clear();
            int index = 1;
            foreach (Location location in locations)
            {
                ListViewItem item = new ListViewItem(index++.ToString());
                item.SubItems.Add(location.PointName);
                item.SubItems.Add(location.X.ToString());
                item.SubItems.Add(location.Y.ToString());
                item.SubItems.Add(location.XO.ToString());
                item.SubItems.Add(location.YO.ToString());
                listView2.Items.Add(item);
            }
            listView2.EndUpdate();
        }

        private void ListView1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = listView1.HitTest(e.Location);
                if (hitTest.Item != null)
                {
                    listView1.FocusedItem = hitTest.Item;
                    contextMenuStrip1.Show(listView1, e.Location);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                int index = listView1.FocusedItem.Index;
                var coordinate = coordinates[index];
                listView1.Items.RemoveAt(index);
                coordinates.RemoveAt(index);
                pointDatas.DeletePoint(coordinate);
                UpdateListView1();
            }
        }

        string currentPointName = "";
        bool currentView1Choose = false;
        private void ListView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                int index = selectedItem.Index;
                var coordinate = coordinates[index];

                // 将 Gps_L 和 Gps_B 存入相应的 TextBox 控件中
                Cal_L.Text = coordinate.Longitude.ToString();
                Cal_B.Text = coordinate.Latitude.ToString();
                currentPointName = coordinate.PointName;
                currentView1Choose = true;
            }
        }

        // 椭球下拉框选择事件
        private void ComboBox_Ellipsoid_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox_Ellipsoid.SelectedItem == null)
            {
                MessageBox.Show("请选择一个椭球");
                return;
            }

            string selectedEllipsoid = comboBox_Ellipsoid.SelectedItem.ToString();
            var selectedSpheroid = spheroids.FirstOrDefault(s => s.Name == selectedEllipsoid);
            if (selectedSpheroid != null)
            {
                text_Spheroid_Name.Text = selectedSpheroid.Name;
                text_Spheroid_a.Text = selectedSpheroid.SemiMajorAxis.ToString();
                text_Spheroid_b.Text = selectedSpheroid.SemiMinorAxis.ToString();
                text_Spheroid_f.Text = selectedSpheroid.Flattening.ToString();
                text_Spheroid_e1.Text = selectedSpheroid.FirstEccentricity.ToString();
                text_Spheroid_e2.Text = selectedSpheroid.SecondEccentricity.ToString();
                text_Spheroid_c.Text = selectedSpheroid.PolarCurvatureRadius.ToString();
            }
        }

        private void button_AddData_Click(object sender, EventArgs e)
        {
            // 创建并显示 AddData 窗体
            AddData addDataForm = new AddData();
            addDataForm.DataAdded1 += AddDataForm_DataAdded1;
            addDataForm.DataAdded2 += AddDataForm_DataAdded2;
            addDataForm.ShowDialog();
        }

        private void AddDataForm_DataAdded1(string pointName, double longitude, double latitude, double elevation)
        {
            Coordinate coordinate = new Coordinate(pointName, longitude, latitude, elevation, "");
            coordinates.Add(coordinate);
            pointDatas.AddPoint(coordinate);
            UpdateListView1();
        }

        private void AddDataForm_DataAdded2(string pointName, double x, double y, double elevation)
        {
            Location location = new Location(pointName, x, y, 0, 0);
            locations.Add(location);
            UpdateListView2();
        }

        public int situation = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            situation = 1;
            Cal_X.Text = "";
            Cal_Y.Text = "";
            if (comboBox_Ellipsoid.SelectedItem == null)
            {
                MessageBox.Show("请选择一个椭球");
                return;
            }
            var selectedSpheroid = spheroids.FirstOrDefault(s => s.Name == comboBox_Ellipsoid.SelectedItem.ToString());
            var transformer = new Transformer.GpsToGaussTransformer(selectedSpheroid);
            double longitude = double.Parse(Cal_L.Text);
            double latitude = double.Parse(Cal_B.Text);
            var (x, y, zno) = transformer.Forward(latitude, longitude);
            Cal_X.Text = x.ToString();
            Cal_Y.Text = y.ToString();
            Cal_ZoneNo.Text = zno.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            situation = 2;
            Cal_B.Text = "";
            Cal_L.Text = "";
            if (comboBox_Ellipsoid.SelectedItem == null)
            {
                MessageBox.Show("请选择一个椭球");
                return;
            }
            var selectedSpheroid = spheroids.FirstOrDefault(s => s.Name == comboBox_Ellipsoid.SelectedItem.ToString());
            var transformer = new Transformer.GpsToGaussTransformer(selectedSpheroid);
            double x = double.Parse(Cal_X.Text);
            double y = double.Parse(Cal_Y.Text);
            int zno = int.Parse(Cal_ZoneNo.Text);
            var (latitude, longitude) = transformer.Inverse(x, y, zno);
            Cal_B.Text = latitude.ToString();
            Cal_L.Text = longitude.ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (situation == 0)
            {
                MessageBox.Show("请先进行坐标转换");
            }
            else
            {
                if (situation == 2)
                {
                    string pointName = "未命名";

                    double longitude = double.Parse(Cal_L.Text);
                    double latitude = double.Parse(Cal_B.Text);
                    double elevation = 0;
                    Coordinate coordinate = new Coordinate(pointName, longitude, latitude, elevation, "");
                    coordinates.Add(coordinate);
                    pointDatas.AddPoint(coordinate);
                    UpdateListView1();
                }
                else if (situation == 1)
                {
                    string pointName = "未命名";
                    if (currentView1Choose == true)
                    {
                        pointName = currentPointName;
                    }
                    double x = double.Parse(Cal_X.Text);
                    double y = double.Parse(Cal_ZoneNo.Text + Cal_Y.Text);
                    double xo = 0;
                    double yo = 0;
                    Location location = new Location(pointName, x, y, xo, yo);
                    locations.Add(location);
                    UpdateListView2();
                }
            }
            currentView1Choose = false;
        }

        private void button_angBL_Click(object sender, EventArgs e)
        {
            if (comboBox_Ellipsoid.SelectedItem == null)
            {
                MessageBox.Show("请选择一个椭球");
                return;
            }
            var selectedSpheroid = spheroids.FirstOrDefault(s => s.Name == comboBox_Ellipsoid.SelectedItem.ToString());
            var transformer = new Transformer.GpsToGaussTransformer(selectedSpheroid);
            double latitude = double.Parse(Cal_B.Text);
            double longitude = double.Parse(Cal_L.Text);
            double ans = transformer.CalculateConvergenceAngleBL(latitude, longitude);
            textBox10.Text = ans.ToString();
        }

        private void button_angXY_Click(object sender, EventArgs e)
        {
            if (comboBox_Ellipsoid.SelectedItem == null)
            {
                MessageBox.Show("请选择一个椭球");
                return;
            }
            var selectedSpheroid = spheroids.FirstOrDefault(s => s.Name == comboBox_Ellipsoid.SelectedItem.ToString());
            var transformer = new Transformer.GpsToGaussTransformer(selectedSpheroid);
            if (Cal_X.Text == "" || Cal_Y.Text == "")
            {
                MessageBox.Show("请输入X,Y坐标或进行正算"); return;
            }
            double x = double.Parse(Cal_X.Text);
            double y = double.Parse(Cal_Y.Text);
            int zno = int.Parse(Cal_ZoneNo.Text);
            double ans = transformer.CalculateConvergenceAngleXY(x, y, zno);
            textBox10.Text = ans.ToString();
        }

        private void button_LO_Click(object sender, EventArgs e)
        {
            int zoneNumber = (int)((double.Parse(Cal_L.Text) + 180) / 6) + 1;
            double centralMeridian = (zoneNumber - 1) * 6 - 180 + 3;
            textBox13.Text = centralMeridian.ToString();

        }

    }

}
