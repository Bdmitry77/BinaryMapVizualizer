using System.Collections.Generic;
using System.Linq;

namespace BinaryMapCounter
{
	public class Counter
	{
		public int Count(List<Character> resultList)
		{
			int areas = 0;

			foreach (var cell in resultList)
			{
				if (FindAdjacentCells(resultList, cell))
					areas++;
			}

			return areas;
		}

		public bool FindAdjacentCells(List<Character> resultList, Character cell)
		{
			if (!cell.IsCounted)
			{
				cell.IsCounted = true;

				var x = cell.Point.X;
				var y = cell.Point.Y;

				FindAdjacentCellsByPoint(resultList, x - 1, y);
				FindAdjacentCellsByPoint(resultList, x + 1, y);
				FindAdjacentCellsByPoint(resultList, x, y - 1);
				FindAdjacentCellsByPoint(resultList, x, y + 1);

				return true;
			}
			else
				return false;
		}

		private void FindAdjacentCellsByPoint(List<Character> resultList, int x, int y)
		{
			var connectedCell = GetCellByPoint(resultList, x, y);
			if (connectedCell != null)
				FindAdjacentCells(resultList, connectedCell);
		}

		private static Character GetCellByPoint(List<Character> resultList, int x, int y)
		{
			return resultList.FirstOrDefault(g => g.Point.X == x & g.Point.Y == y);
		}
	}
}