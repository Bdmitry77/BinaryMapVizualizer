using System;
using System.Collections.Generic;
using System.IO;

namespace BinaryMapCounter
{
	public class Validator
	{
		public List<Character> Validate(string fileName)
		{
			var resultList = new List<Character>();

			using (StreamReader fs = new StreamReader(fileName))
			{
				int rowNumer = 0;
				while (true)
				{
					string row = fs.ReadLine();
					if (row == null)
						break;

					char[] tempChrRow = row.ToCharArray();

					for (int i = 0; i < tempChrRow.Length; i++)
					{
						switch (tempChrRow[i])
						{
							case ' ':
								break;
							case 'x':
								resultList.Add(new Character(new CharacterPoint(rowNumer, i), CharacterType.Occupied));
								break;
							case '#':
								i = tempChrRow.Length;
								break;
							default:
								throw new Exception("Can't validate input data!");
								break;
						}
					}

					rowNumer++;
				}
			}

			return resultList;
		}
	}
}
