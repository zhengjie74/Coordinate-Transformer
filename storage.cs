using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTransform
{
    internal class Storage
    {
        public class Coordinate
        {
            public string PointName { get; set; }
            public double Longitude { get; set; }
            public double Latitude { get; set; }
            public double Elevation { get; set; }
            public string Remark { get; set; }

            public Coordinate(string pointName, double longitude, double latitude, double elevation, string remark)
            {
                PointName = pointName;
                Longitude = longitude;
                Latitude = latitude;
                Elevation = elevation;
                Remark = remark;
            }
        }
        public class Location
        {
            public string PointName { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double XO { get; set; }
            public double YO { get; set; }

            public Location(string pointName, double x, double y, double xo, double yo)
            {
                PointName = pointName;
                X = x;
                Y = y;
                XO = xo;
                YO = yo;
            }
        }
        
    }
}
