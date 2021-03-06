﻿using System.IO;

namespace uLearn
{
	public class SlideInfo
	{
		public int Index { get; set; }
		public Unit Unit { get; private set; }
		public FileInfo SlideFile { get; set; }
		public DirectoryInfo Directory => SlideFile.Directory;

		public SlideInfo(Unit unit, FileInfo slideFile, int index)
		{
			Index = index;
			Unit = unit;
			SlideFile = slideFile;
		}

		public string DirectoryRelativePath => CourseUnitUtils.GetDirectoryRelativeWebPath(SlideFile);
	}
}