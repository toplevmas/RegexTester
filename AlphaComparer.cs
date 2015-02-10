using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace RegexTester
{
	public class AlphaComparer : IComparer<Match>
	{
		public int Compare(Match x, Match y)
		{
			return string.Compare(x.Value, y.Value, true);
		}
	}
}
