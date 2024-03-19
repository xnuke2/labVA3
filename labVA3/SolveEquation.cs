using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace labVA3
{
    internal class SolveEquation
    {
        const uint numOfSteps = 1000000;
        const double accuracy = 0.000001;
        const int numsAfterPoint =6;
        public static double solveTheEquation(double x)
        {
            return (Math.Exp(-x) - 2.6 * x + 4.3);
        }

        public static double solveTheDerivativeEquation(double x)
        {
            return (-Math.Exp(-x) - 2.6);
        }


        public static bool analyticalWayToSeparateRoots(double start, double end)
        {
            if(start >= end) { throw new Exception("начало больше или равно концу"); }
            for(int i = 0;i< numOfSteps-1;i++)
            {
                double x = start +i*((end-start)/numOfSteps);
                double xnext = start + (i+1) * ((end - start) / numOfSteps);
                if (solveTheEquation(x) * solveTheEquation(xnext) < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<string> MethodByDivisionOnHalf(double start, double end)
        {
            if (start >= end) { throw new Exception("начало больше или равно концу"); }
            List<string> result = new List<string>();
            if (!analyticalWayToSeparateRoots(start, end)) { return result; }
            double newStart = start;
            double newEnd = end;
            result.Add("[" + newStart + "," + newEnd + "]");
            double x = (start + end) / 2;
            while (Math.Abs(newStart-newEnd)>accuracy) 
            {
                if(solveTheEquation(newStart)*solveTheEquation(x) < 0) newEnd = x;
                else { newStart = x; }
                x = (newStart + newEnd) / 2;
                result.Add("["+Math.Round( newStart,numsAfterPoint)+","+Math.Round( newEnd,numsAfterPoint)+"]");
            }
            return result;
        }
        public static List<string> MethodNewton (double start, double end)
        {
            if (start >= end) { throw new Exception("начало больше или равно концу"); }
            List<string> result = new List<string>();
            if (!analyticalWayToSeparateRoots(start, end)) { return result; }
            double x = start;
            result.Add(""+x);
            double lastx = x;
            x = findXforNewton(x);
            result.Add("" + x);
            while (Math.Abs(x-lastx)>accuracy)
            {
                lastx = x;
                x = findXforNewton(Math.Round(x,numsAfterPoint));
                result.Add("" + x);
            }
            return result;
        }
        private static double findXforNewton(double x)
        {
            return x-solveTheEquation(x)/solveTheDerivativeEquation(x);
        }
    }
}
