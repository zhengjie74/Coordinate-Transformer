using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTransform
{
    public partial class KDelTabControl : TabControl
    {
        const int CLOSE_SIZE = 15;

        public KDelTabControl()
        {
            this.Padding = new Point(12, 3);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.HotTrack = true;
            this.DrawItem += new DrawItemEventHandler(this.KDelTabControl_DrawItem);
            this.MouseDown += new MouseEventHandler(this.KDelTabControl_MouseDown);
        }

        private void KDelTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                using (SolidBrush s = new SolidBrush(Color.White))
                {
                    Rectangle rect = this.GetTabRect(this.SelectedIndex);
                    e.Graphics.FillRectangle(s, rect);
                }

                Rectangle tab = this.GetTabRect(e.Index);
                e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, tab.X + 2, tab.Y + 2);

                using (Pen p = new Pen(Color.Transparent))
                {
                    tab.Offset(tab.Width - (CLOSE_SIZE + 3), 2);
                    tab.Width = CLOSE_SIZE;
                    tab.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, tab);
                }

                Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.Transparent;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, tab);
                }

                using (Pen objpen = new Pen(Color.Black))
                {
                    Point p1 = new Point(tab.X + 3, tab.Y + 3);
                    Point p2 = new Point(tab.X + tab.Width - 3, tab.Y + tab.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    Point p3 = new Point(tab.X + 3, tab.Y + tab.Height - 3);
                    Point p4 = new Point(tab.X + tab.Width - 3, tab.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);
                }
                e.Graphics.Dispose();
            }
            catch (Exception)
            { }
        }

        private void KDelTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                Rectangle tab = this.GetTabRect(this.SelectedIndex);
                tab.Offset(tab.Width - (CLOSE_SIZE + 3), 2);
                tab.Width = CLOSE_SIZE;
                tab.Height = CLOSE_SIZE;
                bool isClose = x > tab.X && x < tab.Right && y > tab.Y && y < tab.Bottom;

                if (isClose == true)
                {
                    this.TabPages.Remove(this.SelectedTab);
                    if (this.TabPages.Count - 1 > 0)
                    {
                        this.SelectedTab = this.TabPages[this.TabPages.Count - 1];
                    }
                }
            }
        }
    }

}
