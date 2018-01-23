using System.Collections;
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

	public enum WatTeDoen 
	{
		ET ,
		EN ,
		WC ,
		I , 

	}
	public WatTeDoen WTD;

	public void Start()
	{
		nm = this.GetComponent<NavMeshAgent>();
		if (nm == null)
		{
			print("nope" + gameObject.name);
		}
	}

	public void Update()
	{
		Moving();
	}

	public void Moving(){
		//WTD = WatTeDoen.ET;

		if (WTD == WatTeDoen.ET)
		{
			if (nm != null)
			{
			Vector3 trans = foodpos.transform.position;
			nm.SetDestination(trans);
		    }

			print("et");
		 //WTD = WatTeDoen.EN;
		}

		if (WTD == WatTeDoen.EN)
		{
			Vector3 trans = bed.transform.position;
			nm.SetDestination(trans);
			print("en");
			//WTD = WatTeDoen.WC;
		}

		if (WTD == WatTeDoen.WC)
		{
			Vector3 trans = toylet.transform.position;
			nm.SetDestination(trans);
			print("wc");
			//WTD = WatTeDoen.I;
		}

		if (WTD == WatTeDoen.I)
		{
			Vector3 trans = player.transform.position;
			nm.SetDestination(trans);
			print("i");

			//WTD = WatTeDoen.ET;
		}
		

	
		
	}

}


