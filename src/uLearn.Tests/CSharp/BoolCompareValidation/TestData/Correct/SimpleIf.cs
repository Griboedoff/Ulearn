﻿namespace uLearn.CSharp.BoolCompareValidation.TestData.Correct
{
	public class SimpleIf
	{
		public void CheckIfStatementWithoutErrors(int a, int v, bool b)
		{
			if (a == 1){}
			if (b){}
			if (true){}
			if (a == v){}
			if (a != v && a > 0){}
			var q = a == v ? a : v;
			q = a != v ? a : v;
		}
	}
}