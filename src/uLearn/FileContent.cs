﻿namespace uLearn
{
	public class FileContent
	{
		public string Path { get; set; }
		public byte[] Data { get; set; }
		public bool ParentDirectoryFilesWereChanged { get; set; }
	}
}