using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public Slider food;
	//public Slider sleep;

	public void Update()
	{
		if (food.value > 0)
		{
			food.value -= 0.1f * Time.deltaTime ;
		}

		if (food.value >= 1.0f)
		{

		}
	}
}
