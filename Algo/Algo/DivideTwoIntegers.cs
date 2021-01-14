using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class DivideTwoIntegers
    {
		//Bài hơi khó (medium)
		public int Divide(int dividend, int divisor)
		{
			//corner cases, overflow
			if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

			return LongDivision(dividend, divisor);
		}

		public int LongDivision(long dividend, long divisor)
		{
			var divd = Math.Abs(dividend);
			var divr = Math.Abs(divisor);

			var result = 0;
			while (divd >= divr)
			{
				var temp = 1;

				while (divd >= (divr << 1))
				{
					divr = divr << 1;
					temp = temp << 1;
				}

				divd -= divr;
				divr = Math.Abs(divisor);

				result += temp;
			}

			var isNegative = (dividend >= 0 ^ divisor >= 0);

			if (isNegative) result = -result;

			return result;
		}
	}
}
