using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CalculateLength
    {
        int lengthX,_lengthY,lenGthsX,lengthsY;
        public CalculateLength(int lengthX,int lengthY,int lengthsX,int lengthsY)
        {
           this.lengthX = lengthX;
            _lengthY=lengthY;
            lenGthsX = lengthsX;
            this.lengthsY = lengthsY;
        }
        public double Calculate()
        {
            //Line = sqrt (x2 - x1) ^ 2 + (y2 - y1) ^ 2)
            double length = Math.Sqrt(Math.Pow((lenGthsX - lengthX),2) + Math.Pow((lengthsY - _lengthY),2));
            Console.WriteLine(length);
            return length;
        }
    }
}
