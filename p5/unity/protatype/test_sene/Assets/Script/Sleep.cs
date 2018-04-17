using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : Needs
{

	// Use this for initialization
	void Start()
	{
		Zzz();
	}


	public void Zzz()
	{

	}
	void OnTriggerStay(Collider other)
	{//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		print("sleep");
		if (other.tag == "Player")
		{
			slider.value += moreTime * Time.deltaTime;

		}
	}
}
