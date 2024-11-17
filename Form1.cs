using static LocationTransform.Storage;

namespace LocationTransform
{
    public partial class Form1 : Form
    {
        private List<Coordinate> coordinates = new List<Coordinate>();

        public Form1()
        {
            InitializeComponent();
            // 绑定右键菜单事件
            listView1.MouseUp += ListView1_MouseUp;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 绑定选中项改变事件
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
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

                            Storage.Coordinate coordinate = new Storage.Coordinate(pointName, longitude, latitude, elevation, remark);
                            coordinates.Add(coordinate);
                        }
                    }

                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
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

        private void ListView1_MouseUp(object sender, MouseEventArgs e)
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

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(index);
                coordinates.RemoveAt(index);
                UpdateListView();
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                int index = selectedItem.Index;
                var coordinate = coordinates[index];

                // 将 Gps_L 和 Gps_B 存入相应的 TextBox 控件中
                Cal_L.Text = coordinate.Longitude.ToString();
                Cal_B.Text = coordinate.Latitude.ToString();
            }
        }
    }

}
