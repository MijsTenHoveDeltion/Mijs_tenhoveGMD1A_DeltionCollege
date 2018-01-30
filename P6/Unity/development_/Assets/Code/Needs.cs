using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public List<Slider> sl = new List<Slider>();

	public Slider slider;

	//public GameObject thisobject;

	public Move move;
	//	public Food food;
	//	public Apple apple;
	//	public Coffie coffie;

	public float time = 0.1f;
	public float getting = 2f;

	public void Update()
	{
		LowerBar();
		Movingto();
	}

	public void LowerBar()
	{
		if (slider.value > slider.minValue)
		{
			slider.value -= time * Time.deltaTime;
		}
	}

	public void Movingto()
	{// een forloop gaat door de list met sliders. dan kijkt hij of de sliders value minder of gelijk is aan 1. zo ja i gelijk aan intje 
		for (int i = 0; i < sl.Count; i++)
		{
			if (sl[i].value <= 1)
			{

				move.intje = i;
			}
		}
		move.Moving();
	}
	// als het gameobject colide met het gameobject en als de slider h=niet helemaal vol is. dan "laat je weer op"
	public void OnTriggerStay(Collider other)
	{
		print("dytk");
		slider.value += getting * Time.deltaTime;
	}
}




	


