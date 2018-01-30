using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public List<Slider> sl = new List<Slider>();

	public Slider slider;

	public Move move;
	//public Food food;
	//public Apple apple;
	public float time = 0.1f;
	public float getting = 1.1f;
	public GameObject pennel;
	
	

	public void Update()
	{
		LowerBar();
		Movingto();
		move.Moving();
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
			if (sl[i].value <= 0)
			{
				print (i);
				pennel.SetActive(true);
				//move.intje = i;	
			}
		}
			
	}
	public void OnTriggerExit(Collider other)
	{
		slider.value += getting * Time.deltaTime;
	}
	public void OnTriggerEnter(Collider other)
	{// als het gameobject colide met het gameobject en als de slider h=niet helemaal vol is. dan "laat je weer op"
		slider.value += getting * Time.deltaTime;

		if (slider.value < slider.maxValue)
		{
			//print("slow");
			
			//print("slower");
			//apple.Eating();
			//print("slowest");
		}
	}
	public void OnCollisionStay(Collision collision)
	{
		slider.value += getting * Time.deltaTime;
	}
}




	


