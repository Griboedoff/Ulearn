﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLearn
{
	public class UsersStatsPageModel
	{
		public CoursePageModel CoursePageModel;
		public Dictionary<string, SortedDictionary<string, int>> UserStats;
		public List<string> UnitNamesInOrdered;
	}
}