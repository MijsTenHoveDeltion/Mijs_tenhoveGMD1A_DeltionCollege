using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollerLetter : MonoBehaviour {

	public Text t1;
	

	public Color[] color;

	public int whatCollor;


	public void Update()
	{
		for (int i = 0; i < color.Length; i++)
		{
			if (whatCollor == i)
			{
				t1.color = color[i];
			}
		}
	}
	public void Colortext(int index)
	{
		whatCollor = index;
	}
}
