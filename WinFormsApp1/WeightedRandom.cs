using System;

namespace howto_histogram
{
    public class WeightedRandom : Random
    {
            // adjusts the normal curve toward the right (higher) end depending on number of chargesdused. 
            public WeightedRandom(double _A, double _B, double _C, double _D) : base()
            {
                A = _A;
                B = _B;
                C = _C;
                D = _D;
            }

            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double D { get; set; }

            protected override double Sample()
            {
                double x = base.Sample();
                return A * x * x * x * x + B * x * x * x + C * x * x + D * x;
            }
            public override int Next(int MaxValue)
            {
                return (int) (Sample() * MaxValue);
            }
            
    }
}