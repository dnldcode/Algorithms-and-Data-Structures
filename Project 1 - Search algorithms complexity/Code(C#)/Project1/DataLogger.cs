using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	class DataLogger
	{
		public static void LogData(string fileName, string[] columnLabels, int[,] data)
		{
			StreamWriter streamWriter = new StreamWriter(path: Directory.GetCurrentDirectory() + "\\" + fileName, append: true);

			for (int i = 0; i < data.GetLength(1); i++)
			{
				string str = "";

				if (i != 0)
				{
					for (int j = 0; j < data.Length; j++)
						str += data[i, j] + "\t";
				}
				else
				{
					for (int j = 0; j < columnLabels.Length; j++)
						str += columnLabels[j] + "\t";
				}

				streamWriter.WriteLine(str);

			}

			streamWriter.Close();
		}
	}
}
