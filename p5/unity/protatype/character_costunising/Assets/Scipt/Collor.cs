using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collor : MonoBehaviour
{
	//public List<SpriteRenderer> sp = new List<SpriteRenderer>();
	public SpriteRenderer spullen;
	public Image sqere;
	public Color[] color;

	public int whatCollor;


	public void Update()
	{
		for (int i = 0; i < color.Length; i++)
		{
			if (whatCollor == i)
			{
				spullen.color = color[i];
				
			}

				
		}

	}
	public void Colorbodie(int index)
	{
		whatCollor = index;
	}


}
