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

        /*public static List<Coordinate> coordinates = new List<Coordinate>();
        public static List<Coordinate> Coordinates
        {
            get { return coordinates; }
        }
        public static void AddCoordinate(Coordinate coordinate)
        {
            coordinates.Add(coordinate);
        }
        public static void RemoveCoordinate(Coordinate coordinate)
        {
            coordinates.Remove(coordinate);
        }
        public static void ClearCoordinates()
        {
            coordinates.Clear();
        }*/
    }
}
