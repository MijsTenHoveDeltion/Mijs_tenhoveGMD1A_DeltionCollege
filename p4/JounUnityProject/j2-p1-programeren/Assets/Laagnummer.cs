using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Laagnummer : MonoBehaviour
{
	public List<int> SortList(List<int> toSort)
	{
		List<int> toReturn = new List<int>();
		int lowest = int.MaxValue;
		int index = 0;

		while (toSort.Count > 0)
		{
			lowest = int.MaxValue;
			for (int i = 0; i < toSort.Count; i++)
			{
				if (toSort[i] <= lowest)
				{
					lowest = toSort[i];
					index = i;
				}
			}
			toReturn.Add(lowest);
			
			toSort.RemoveAt(index);
		}
	}
}
