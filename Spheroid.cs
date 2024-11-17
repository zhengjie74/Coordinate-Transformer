using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTransform
{
    internal class Spheroid
    {
        // 椭球名称
        public string Name { get; set; }

        // 椭球长半径 a
        public double SemiMajorAxis { get; set; }

        // 椭球短半径 b
        public double SemiMinorAxis { get; set; }

        // 第一偏心率
        public double FirstEccentricity { get; set; }

        // 第二偏心率
        public double SecondEccentricity { get; set; }

        // 扁率
        public double Flattening { get; set; }

        // 极曲率半径
        public double PolarCurvatureRadius { get; set; }

        // 构造函数
        public Spheroid(string name, double semiMajorAxis, double semiMinorAxis, double firstEccentricity, double secondEccentricity, double flattening, double polarCurvatureRadius)
        {
            Name = name;
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
            FirstEccentricity = firstEccentricity;
            SecondEccentricity = secondEccentricity;
            Flattening = flattening;
            PolarCurvatureRadius = polarCurvatureRadius;
        }
    }
}
