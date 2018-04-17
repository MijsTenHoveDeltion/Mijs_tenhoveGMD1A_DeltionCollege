using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Needs : MonoBehaviour
{
	public float minimum;
	public float time;
	public float moreTime;
	public Transform place;
	public Slider slider;
	public NavMeshAgent nm;

	public void Update()
	{
		
		PrintBace();
	}


	public void PrintBace()
	{
		if (slider.value > slider.minValue)
		{
			slider.value -= time * Time.deltaTime;
		}

		if (slider.value <= minimum)
		{
		Vector3 trans = place.transform.position;
		nm.SetDestination(trans);
		}
	}
	/*void OnTriggerStay(Collider other)
	{//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		print("stuf");
		slider.value += moreTime* Time.deltaTime;
		
	}*/
}
