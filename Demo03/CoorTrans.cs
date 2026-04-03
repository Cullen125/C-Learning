using System;

namespace Demo03
{
    internal class CoorTrans
    {
        private const double a = 6378137.0;
        private const double f = 1.0 / 298.257222101;

        public void BLH2XYZ(double B, double L, double H,
            out double X, out double Y, out double Z)
        {
            double e2 = ComputerE2();
            double N = ComputerN(B);

            double b = Deg2Rad(B);
            double l = Deg2Rad(L);

            X = (N + H) * Math.Cos(b) * Math.Cos(l);
            Y = (N + H) * Math.Cos(b) * Math.Sin(l);
            Z = (N * (1 - e2) + H) * Math.Sin(b);
        }

        public void XYZ2BLH(double X, double Y, double Z,
            out double B, out double L, out double H)
        {
            L = ComputerL(X, Y);

            double B0 = 0;
            double detaB;

            do
            {
                H = ComputerH(X, Y, B0);
                B = ComputerB(B0, X, Y, Z, H);
                detaB = B - B0;
                B0 = B;
            }
            while (Math.Abs(detaB) > 1e-10);

            B = B0;
            H = ComputerH(X, Y, B);
        }

        private double ComputerH(double X, double Y, double B)
        {
            double N = ComputerN(B);
            double H = Math.Sqrt(X * X + Y * Y) / Math.Cos(Deg2Rad(B)) - N;
            return H;
        }

        private double ComputerB(double B0, double X, double Y, double Z, double H)
        {
            double e2 = ComputerE2();
            double N = ComputerN(B0);
            double upper = Z * (N + H);
            double under = Math.Sqrt(X * X + Y * Y) * (N * (1 - e2) + H);
            double B = Math.Atan(upper / under);
            B = Rad2Deg(B);
            return B;
        }

        private double ComputerL(double X, double Y)
        {
            double L = Math.Atan2(Y, X);
            L = Rad2Deg(L);
            if (L < 0) L += 360;
            return L;
        }

        private double ComputerE2()
        {
            double e2 = 2 * f - f * f;
            return e2;
        }

        private double ComputerN(double B)
        {
            double e2 = ComputerE2();
            double b = Deg2Rad(B);
            double sinb = Math.Sin(b);
            double W = Math.Sqrt(1 - e2 * sinb * sinb);
            double N = a / W;
            return N;
        }

        private double Deg2Rad(double deg)
        {
            return deg * Math.PI / 180.0;
        }

        private double Rad2Deg(double rad)
        {
            return rad * 180.0 / Math.PI;
        }
    }
}
