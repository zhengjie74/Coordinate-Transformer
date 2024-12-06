using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTransform
{
    internal class Transformer
    {
        public class GpsToGaussTransformer
        {
            private const double Pi = Math.PI;
            private readonly Spheroid _spheroid;

            public GpsToGaussTransformer(Spheroid spheroid)
            {
                _spheroid = spheroid;
            }

            // 正算：从经纬度到高斯平面坐标
            public (double X, double Y, double ZONENO) Forward(double latitude, double longitude, int zoneWidth = 6)
            {
                int zoneNumber = (int)((longitude + 180) / zoneWidth) + 1;
                double centralMeridian = (zoneNumber - 1) * zoneWidth - 180 + zoneWidth / 2.0;
                double radLat = latitude * Pi / 180.0;
                double radLon = longitude * Pi / 180.0;
                double radCentralMeridian = centralMeridian * Pi / 180.0;

                double a = _spheroid.SemiMajorAxis;
                double e2 = _spheroid.FirstEccentricity;
                double e2Prime = e2 / (1 - e2);

                double N = a / Math.Sqrt(1 - e2 * Math.Sin(radLat) * Math.Sin(radLat));
                double T = Math.Tan(radLat) * Math.Tan(radLat);
                double C = e2Prime * Math.Cos(radLat) * Math.Cos(radLat);
                double A = (radLon - radCentralMeridian) * Math.Cos(radLat);

                double M = a * ((1 - e2 / 4 - 3 * e2 * e2 / 64 - 5 * e2 * e2 * e2 / 256) * radLat
                    - (3 * e2 / 8 + 3 * e2 * e2 / 32 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(2 * radLat)
                    + (15 * e2 * e2 / 256 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(4 * radLat)
                    - (35 * e2 * e2 * e2 / 3072) * Math.Sin(6 * radLat));

                double x = M + N * Math.Tan(radLat) * (A * A / 2
                    + (5 - T + 9 * C + 4 * C * C) * A * A * A * A / 24
                    + (61 - 58 * T + T * T + 600 * C - 330 * e2Prime) * A * A * A * A * A * A / 720);

                double y = N * (A + (1 - T + C) * A * A * A / 6
                    + (5 - 18 * T + T * T + 72 * C - 58 * e2Prime) * A * A * A * A * A / 120);

                return (x, y + 500000, zoneNumber);
            }

            // 反算：从高斯平面坐标到经纬度
            public (double Latitude, double Longitude) Inverse(double x, double y, int zoneNumber, int zoneWidth = 6)
            {
                double centralMeridian = (zoneNumber - 1) * zoneWidth - 180 + zoneWidth / 2.0;
                double radCentralMeridian = centralMeridian * Pi / 180.0;

                // 减去500000米的假东坐标
                y -= 500000;

                double a = _spheroid.SemiMajorAxis;
                double e2 = _spheroid.FirstEccentricity;
                double e2Prime = e2 / (1 - e2);

                double M = x;
                double mu = M / (a * (1 - e2 / 4 - 3 * e2 * e2 / 64 - 5 * e2 * e2 * e2 / 256));

                double e1 = (1 - Math.Sqrt(1 - e2)) / (1 + Math.Sqrt(1 - e2));
                double J1 = 3 * e1 / 2 - 27 * e1 * e1 * e1 / 32;
                double J2 = 21 * e1 * e1 / 16 - 55 * e1 * e1 * e1 * e1 / 32;
                double J3 = 151 * e1 * e1 * e1 / 96;
                double J4 = 1097 * e1 * e1 * e1 * e1 / 512;

                double fp = mu + J1 * Math.Sin(2 * mu) + J2 * Math.Sin(4 * mu) + J3 * Math.Sin(6 * mu) + J4 * Math.Sin(8 * mu);

                double C1 = e2Prime * Math.Cos(fp) * Math.Cos(fp);
                double T1 = Math.Tan(fp) * Math.Tan(fp);
                double N1 = a / Math.Sqrt(1 - e2 * Math.Sin(fp) * Math.Sin(fp));
                double R1 = a * (1 - e2) / Math.Pow(1 - e2 * Math.Sin(fp) * Math.Sin(fp), 1.5);
                double D = y / N1;

                double Q1 = N1 * Math.Tan(fp) / R1;
                double Q2 = (D * D / 2);
                double Q3 = (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * e2Prime) * D * D * D * D / 24;
                double Q4 = (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * e2Prime - 3 * C1 * C1) * D * D * D * D * D * D / 720;

                double lat = fp - Q1 * (Q2 - Q3 + Q4);

                double Q5 = D;
                double Q6 = (1 + 2 * T1 + C1) * D * D * D / 6;
                double Q7 = (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * e2Prime + 24 * T1 * T1) * D * D * D * D * D / 120;

                double lon = radCentralMeridian + (Q5 - Q6 + Q7) / Math.Cos(fp);

                return (lat * 180.0 / Pi, lon * 180.0 / Pi);
            }

            // 计算BL收敛角
            public double CalculateConvergenceAngleBL(double latitude, double longitude, int zoneWidth = 6)
            {
                int zoneNumber = (int)((longitude + 180) / zoneWidth) + 1;
                double centralMeridian = (zoneNumber - 1) * zoneWidth - 180 + zoneWidth / 2.0;
                double radLat = latitude * Pi / 180.0;
                double radLon = longitude * Pi / 180.0;
                double radCentralMeridian = centralMeridian * Pi / 180.0;

                double convergenceAngle = Math.Atan(Math.Tan(radLon - radCentralMeridian) * Math.Sin(radLat));
                return convergenceAngle * 180.0 / Pi;
            }

            // 计算XY收敛角
            public double CalculateConvergenceAngleXY(double x, double y, int zoneNumber, int zoneWidth = 6)
            {
                var (latitude, longitude) = Inverse(x, y, zoneNumber, zoneWidth);
                return CalculateConvergenceAngleBL(latitude, longitude, zoneWidth);
            }
        }
    }
}
