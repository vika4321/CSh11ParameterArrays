#region Using directives
using System;
#endregion

namespace ParamsArray
{
	class Util
	{
		public static int Sum(params int[] paramList)
		{
			Console.WriteLine("Using paramter list");
			if (paramList == null)
			{
				throw new ArgumentException("Util.Sum: null paramList" );
			}
			if(paramList.Length == 0)
			{
				throw new ArgumentException("Util.Sum: empty paramList");
			}
			int sum = 0;
			foreach (int item in paramList)
			{
				 sum = sum + item;

			}
			return sum;
		}

		public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
		{
			Console.WriteLine("Using optional parameters");
			int sum = param1 + param2 + param3 + param4;
			return sum;
		}
	}
}