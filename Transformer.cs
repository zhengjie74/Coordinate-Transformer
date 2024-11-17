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
            public (double X, double Y) Forward(double latitude, double longitude, int zoneWidth = 6)
            {
                int zoneNumber = (int)((longitude + 180) / zoneWidth) + 1;
                double centralMeridian = (zoneNumber - 1) * zoneWidth - 180 + zoneWidth / 2.0;
                double radLat = latitude * Pi / 180.0;
                double radLon = longitude * Pi / 180.0;
                double radCentralMeridian = centralMeridian * Pi / 180.0;

                double N = _spheroid.SemiMajorAxis / Math.Sqrt(1 - _spheroid.FirstEccentricity * Math.Sin(radLat) * Math.Sin(radLat));
                double T = Math.Tan(radLat) * Math.Tan(radLat);
                double C = _spheroid.FirstEccentricity * Math.Cos(radLat) * Math.Cos(radLat) / (1 - _spheroid.FirstEccentricity);
                double A_ = (radLon - radCentralMeridian) * Math.Cos(radLat);

                double M = _spheroid.SemiMajorAxis * ((1 - _spheroid.FirstEccentricity / 4 - 3 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 64 - 5 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 256) * radLat
                    - (3 * _spheroid.FirstEccentricity / 8 + 3 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 32 + 45 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 1024) * Math.Sin(2 * radLat)
                    + (15 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 256 + 45 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 1024) * Math.Sin(4 * radLat)
                    - (35 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 3072) * Math.Sin(6 * radLat));

                double x = N * (A_ + (1 - T + C) * A_ * A_ * A_ / 6
                    + (5 - 18 * T + T * T + 72 * C - 58 * _spheroid.SecondEccentricity) * A_ * A_ * A_ * A_ * A_ / 120);
                double y = M + N * Math.Tan(radLat) * (A_ * A_ / 2
                    + (5 - T + 9 * C + 4 * C * C) * A_ * A_ * A_ * A_ / 24
                    + (61 - 58 * T + T * T + 600 * C - 330 * _spheroid.SecondEccentricity) * A_ * A_ * A_ * A_ * A_ * A_ / 720);

                return (x, y);
            }

            // 反算：从高斯平面坐标到经纬度
            public (double Latitude, double Longitude) Inverse(double x, double y, int zoneNumber, int zoneWidth = 6)
            {
                double centralMeridian = (zoneNumber - 1) * zoneWidth - 180 + zoneWidth / 2.0;
                double radCentralMeridian = centralMeridian * Pi / 180.0;

                double M = y;
                double mu = M / (_spheroid.SemiMajorAxis * (1 - _spheroid.FirstEccentricity / 4 - 3 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 64 - 5 * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity * _spheroid.FirstEccentricity / 256));

                double e1 = (1 - Math.Sqrt(1 - _spheroid.FirstEccentricity)) / (1 + Math.Sqrt(1 - _spheroid.FirstEccentricity));
                double J1 = 3 * e1 / 2 - 27 * e1 * e1 * e1 / 32;
                double J2 = 21 * e1 * e1 / 16 - 55 * e1 * e1 * e1 * e1 / 32;
                double J3 = 151 * e1 * e1 * e1 / 96;
                double J4 = 1097 * e1 * e1 * e1 * e1 / 512;

                double fp = mu + J1 * Math.Sin(2 * mu) + J2 * Math.Sin(4 * mu) + J3 * Math.Sin(6 * mu) + J4 * Math.Sin(8 * mu);

                double C1 = _spheroid.FirstEccentricity * Math.Cos(fp) * Math.Cos(fp) / (1 - _spheroid.FirstEccentricity);
                double T1 = Math.Tan(fp) * Math.Tan(fp);
                double N1 = _spheroid.SemiMajorAxis / Math.Sqrt(1 - _spheroid.FirstEccentricity * Math.Sin(fp) * Math.Sin(fp));
                double R1 = _spheroid.SemiMajorAxis * (1 - _spheroid.FirstEccentricity) / Math.Pow(1 - _spheroid.FirstEccentricity * Math.Sin(fp) * Math.Sin(fp), 1.5);
                double D = x / N1;

                double Q1 = N1 * Math.Tan(fp) / R1;
                double Q2 = (D * D / 2);
                double Q3 = (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * _spheroid.FirstEccentricity) * D * D * D * D / 24;
                double Q4 = (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * _spheroid.FirstEccentricity - 3 * C1 * C1) * D * D * D * D * D * D / 720;

                double lat = fp - Q1 * (Q2 - Q3 + Q4);

                double Q5 = D;
                double Q6 = (1 + 2 * T1 + C1) * D * D * D / 6;
                double Q7 = (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * _spheroid.FirstEccentricity + 24 * T1 * T1) * D * D * D * D * D / 120;

                double lon = radCentralMeridian + (Q5 - Q6 + Q7) / Math.Cos(fp);

                return (lat * 180.0 / Pi, lon * 180.0 / Pi);
            }
        }
    }
}
