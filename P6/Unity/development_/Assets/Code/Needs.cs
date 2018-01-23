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
	{
		for (int i = 0; i < sl.Count; i++)
		{
			if (sl[i].value <= 1)
			{
				//move.WTD = Move.WatTeDoen./*wat het laagts is */;
			}
		}
			move.Moving();
	}

	public void OnTriggerEnter(Collider other)
	{
		print("coll");
		if (slider.value < slider.maxValue)
		{
			slider.value += getting * Time.deltaTime;
		}
	}
}




	


