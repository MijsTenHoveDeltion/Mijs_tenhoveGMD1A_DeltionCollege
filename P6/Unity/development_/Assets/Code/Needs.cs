using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public List<Slider> sl = new List<Slider>();

	public Slider slider;

	public Slider foodSlider;
	public Slider energie;
	public Move move;
	public BasicNeed need;
	public Apple apple;
	public float time = 0.1f;
	bool coffie;

	public void Update()
	{
		LowerBar();
		Movingto();
	}
	public void OnTriggerEnter(Collider other)
	{//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		print("enter");
		if (coffie == true)
		{
			apple.Engergie();
		}
		need.Needing();
	}
	
	public void LowerBar()
	{// om de sliders te laten aftellen
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
				if (foodSlider.value <= 1 && energie.value <= 1)
				{
				move.intje = 0;
				coffie = true;
				}
				else
				{
				coffie = false;
				move.intje = i;
				}
			}
		}
			move.Moving();
	}
}




	


