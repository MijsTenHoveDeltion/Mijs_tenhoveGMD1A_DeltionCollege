using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hygne : Needs
{
	public float littleTime;

	void OnTriggerStay(Collider other)
	{
		//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		if (other.tag == "Player")
		{
			slider.value += littleTime * Time.deltaTime;

		}
	}


}
