using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nummbers : MonoBehaviour
{
	public List<int> Test2 = new List<int>();
	public List<int> Test1 = new List<int>();

	public void Start()
	{
		Test1 = GetOddNumbers(Test2);
	}

	public List<int> GetOddNumbers (List<int> intje)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < intje.Count; i++)
		{
			
			if (intje[i] % 2 != 0)
				// % int kijkt of hij deelbaar is aan de int
			{
				list.Add(intje[i]);
				
			}
			
		}
		
		return list;
	}
}
