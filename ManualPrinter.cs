using System;
using System.Collections.Generic;
using System.Text;

namespace ColorCoderProject
{
	public class ManualPrinter: IManualOutput
	{
		public void PrintLine(string line)
		{
			Console.WriteLine(line);

		}
		

	}
}