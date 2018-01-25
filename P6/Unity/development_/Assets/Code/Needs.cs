using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public List<Slider> sl = new List<Slider>();

	public Slider slider;

	public Move move;
	public float time = 0.1f;
	public float getting = 1.1f;

	public void Update()
	{
		LowerBar();
		Movingto();
	}

	public void LowerBar()
	{
		if (slider.value > slider.minValue )
		{
			slider.value -= time * Time.deltaTime ;
		}
	}

	public void Movingto()
	{// een forloop gaat door de list met sliders. dan kijkt hij of de sliders value minder of gelijk is aan 1. zo ja i gelijk aan intje 
		for (int i = 0; i < sl.Count; i++)
		{
			if (sl[i].value <= 1)
			{
				print (i);
				move.intje = i;	
			}
		}
			move.Moving();
	}

	public void OnTriggerEnter(Collider other)
	{// als het gameobject colide met het gameobject en als de slider h=niet helemaal vol is. dan "laat je weer op"
		if (slider.value < slider.maxValue)
		{
			slider.value += getting * Time.deltaTime;
		}
	}
}




	


