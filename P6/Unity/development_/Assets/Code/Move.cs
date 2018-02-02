﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Move : MonoBehaviour
{
	
	public NavMeshAgent nm;
	public Transform foodpos;
	public Transform bed;
	public Transform toylet;
	public Transform player;
	public int intje;

	// een enum voor de verschildende pozieties voor de player 
	public enum WatTeDoen 
	{
		ET = 0,
		EN = 1,
		WC = 2,
		I = 3, 

	}
	public WatTeDoen WTD;

	public void Moving(){
		if (intje == (int)WatTeDoen.ET)
		{
			Vector3 trans = foodpos.transform.position;
			nm.SetDestination(trans);
		}

		if (intje == (int)WatTeDoen.EN)
		{
			Vector3 trans = bed.transform.position;
			nm.SetDestination(trans);
		}

		if (intje == (int)WatTeDoen.WC)
		{
			Vector3 trans = toylet.transform.position;
			nm.SetDestination(trans);
		}

		if (intje == (int)WatTeDoen.I)
		{
			Vector3 trans = player.transform.position;
			nm.SetDestination(trans);
		}
	}
}


