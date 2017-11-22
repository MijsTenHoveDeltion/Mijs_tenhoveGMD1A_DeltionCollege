using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collor : MonoBehaviour
{
	public GameObject penel;

	public SpriteRenderer hooft;
	public SpriteRenderer armen;
	public SpriteRenderer bennen;
	public SpriteRenderer torso;
	public SpriteRenderer neus1;
	public Sprite neus2;


	public Image sqere;


	public Color white;
	public Color pink;
	public Color coffe;
	public Color dark;
	public Color green;

	public int whatCollor ;

	

	public void Update()
	{
		if (whatCollor == 1)
		{
			hooft.color = white;
			armen.color = white;
			bennen.color = white;
			torso.color = white;
			sqere.color = white;
			if (neus1.sprite != neus2)
			{
				neus1.color = white;
			}
		}
		else if (whatCollor == 2)
		{
			hooft.color = pink;
			armen.color = pink;
			bennen.color = pink;
			torso.color = pink;
			sqere.color = pink;
			if (neus1.sprite != neus2)
			{
				neus1.color = pink;
			}
		}
		else if (whatCollor == 3)
		{
			hooft.color = coffe;
			armen.color = coffe;
			bennen.color = coffe;
			torso.color = coffe;
			sqere.color = coffe;
			if (neus1.sprite != neus2)
			{
				neus1.color = coffe;
			}
		}
		else if (whatCollor == 4 )
		{
			hooft.color = dark;
			armen.color = dark;
			bennen.color = dark;
			torso.color = dark;
			sqere.color = dark;
			if (neus1.sprite != neus2)
			{
				neus1.color = dark;
			}
		}
		else if (whatCollor == 5)
		{
			hooft.color = green;
			armen.color = green;
			bennen.color = green;
			torso.color = green;
			sqere.color = green;
			if (neus1.sprite != neus2)
			{
				neus1.color = green;
			}
		}
	}


	public void OpenPenel()
	{
		penel.SetActive(true);
		
	}

	public void ClosePenel()
	{
		penel.SetActive(false);
	}




	public void ColorWhite()
	{
		whatCollor = 1;
	}
	public void ColorPink()
	{
		whatCollor = 2;
	}
	public void ColorCoffe()
	{
		whatCollor = 3;
	}
	public void ColorDark()
	{
		whatCollor = 4;
	}
	public void ColorGreen()
	{
		whatCollor = 5;
	}
	
}
