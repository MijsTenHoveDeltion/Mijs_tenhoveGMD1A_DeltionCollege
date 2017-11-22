using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chansing : MonoBehaviour
{
	public SpriteRenderer nose;
	public SpriteRenderer part;
	public Sprite[] option;
	public int index;

	// Use this for initialization
	void Update ()
	{
		for (int  i = 0;  i < option.Length; i++)
		{
			if (i == index)
			{
				part.sprite = option[i];
			}
		}
	}

	public void Swap()
	{
		if (index < option.Length - 1)
		{
			index++;
		}
		else
		{
			index = 0;
		}

	}

}


