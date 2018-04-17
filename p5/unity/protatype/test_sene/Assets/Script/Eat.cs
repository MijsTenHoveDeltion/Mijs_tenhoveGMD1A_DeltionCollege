using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : Needs
{
	public void Start()
	{
		HapHap();
	}

	public void HapHap()
	{


	}

	void OnTriggerStay(Collider other)
	{
		//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		print("nee");
		if (other.tag == "Player")
		{
		print("food");
			slider.value += moreTime * Time.deltaTime;

		}
	}
}
