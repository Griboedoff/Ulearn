﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace unify_xml
{
	class Program
	{
		static void Main(string[] args)
		{
			T();
			return;
			var dirname = args[0];
			foreach (string xmlFile in Directory.EnumerateFiles(dirname, "*.xml", SearchOption.AllDirectories))
			{
				try
				{
					var content = File.ReadAllText(xmlFile);
					var xdoc = XDocument.Load(new StringReader(content));
					var doc = Unify(xdoc);
					string finalContent = doc.Root.ToString();
					finalContent = finalContent.Replace(" />", "/>").TrimEnd();
					if (finalContent != content)
					{
						Console.WriteLine(xmlFile);
						File.WriteAllText(xmlFile, finalContent);
					}
				}
				catch (Exception e)
				{
					Console.Error.WriteLine(e.ToString());
				}
			}
		}

		private static void T()
		{
			var s = new Stack<int>();
			var res = new List<int>();
			s.Push(1);
			s.Push(2);
			res.Add(s.Pop());
			s.Push(3);
			s.Push(4);
			res.Add(s.Pop());
			res.Add(s.Pop());
			res.Add(s.Pop());
			Console.WriteLine(string.Join(" ", res));

		}

		private static XDocument Unify(XDocument xdoc)
		{
			var xdocRoot = xdoc.Root ?? throw new Exception("Empty xml?");
			var orderedAttrs = xdocRoot.Attributes().OrderBy(a => a.Name.LocalName).Cast<object>().ToArray();
			xdocRoot.ReplaceAttributes(orderedAttrs);
			return xdoc;
		}
	}
}
