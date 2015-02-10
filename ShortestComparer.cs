using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace RegexTester
{
	public class ShortestComparer : IComparer<Match>
	{
		public int Compare(Match x, Match y)
		{
			return x.Length.CompareTo(y.Length);
		}
	}
}
