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

/*	public enum DeEnum
	{
		ET,
		EN,
		WC,
	}*/
	//public DeEnum ED;

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
	/*public void Moving()
	{
		if (intje == (int)DeEnum.ET)
		{
			Vector3 trans = place.transform.position;
			nm.SetDestination(trans);
		}

		if (intje == (int)DeEnum.EN)
		{
			Vector3 trans = place.transform.position;
			nm.SetDestination(trans);
		}

		if (intje == (int)DeEnum.WC)
		{
			Vector3 trans = place.transform.position;
			nm.SetDestination(trans);
		}*/
	}

