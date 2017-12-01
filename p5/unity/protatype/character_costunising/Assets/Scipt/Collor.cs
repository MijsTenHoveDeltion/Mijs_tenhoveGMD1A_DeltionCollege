using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collor : MonoBehaviour
{
	//public List<SpriteRenderer> sp = new List<SpriteRenderer>();
	public SpriteRenderer s1;
	public SpriteRenderer s2;
	public SpriteRenderer s3;
	public SpriteRenderer s4;
	public SpriteRenderer s5;
	public SpriteRenderer s6;
	public SpriteRenderer s7;


	public Image sqere;
	public Color[] color;

	public int whatCollor;


	public void Update()
	{
		for (int i = 0; i < color.Length; i++)
		{
			if (whatCollor == i)
			{
				s1.color = color[i];
				s2.color = color[i];
				s3.color = color[i];
				s4.color = color[i];
				s5.color = color[i];
				s6.color = color[i];
				s7.color = color[i];
			}

				
		}

	}
	public void Colorbodie(int index)
	{
		whatCollor = index;
	}


}
