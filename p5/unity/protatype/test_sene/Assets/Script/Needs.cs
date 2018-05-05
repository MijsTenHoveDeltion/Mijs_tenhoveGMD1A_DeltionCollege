using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Needs : MonoBehaviour
{
	public int intje;
	public float minimum;
	public float time;
	public Transform place;
	public Slider slider;
	public NavMeshAgent nm;
	public Statething playerskript;


	public void Update()
	{
		PrintBace();
	}

	public void PrintBace()
	{//kijkt eerst al de slider value niet 0 zo nee haalt het er met tijd ietjs er af.
		if (slider.value > slider.minValue)
		{
			slider.value -= time * Time.deltaTime;
		}
	

		if (slider.value <= minimum)
		{
			//zet statmachine naar walking dan verplaast de cubes naar de pozietie die hij moet.
			playerskript.ED = Statething.DeEnum.walking;
			
				Vector3 trans = place.transform.position;
				nm.SetDestination(trans);

		}
	}

}

