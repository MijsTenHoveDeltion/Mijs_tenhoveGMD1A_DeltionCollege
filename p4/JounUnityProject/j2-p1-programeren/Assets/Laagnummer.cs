using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Laagnummer : MonoBehaviour
{
	public List<int> ListInt = new List<int>();
	public List<int> ListInt2 = new List<int>();

	public void Start()
	{
		ListInt = GetLowestNumber(ListInt2);
	}

	public void GetLowestNumber(List<int> inde)
	{
		for (int i = 0; i < inde.Count; i++)
		{

			//andere for om te tjeken wat het laagste nummer is
			
		}
	}
	
}
