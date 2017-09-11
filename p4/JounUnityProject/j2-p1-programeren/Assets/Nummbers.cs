using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nummbers : MonoBehaviour
{
	public List<int> list = new List<int>();
	public List<int> Test1 = new List<int>();

	public void Start()
	{
		Test1 = GetOddNumbers(list);
	}

	public List<int> GetOddNumbers (List<int> intje)
	{
		print("a");
		for (int i = 0; i < list.Count; i++)
		{
			print("b");
			if (list[i] % 2 != 0)
			{
				list.Add(i);
				print("hoi");
			}
			
		}
		
		return intje;
	}
}
