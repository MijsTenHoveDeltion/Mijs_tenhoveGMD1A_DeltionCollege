using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hygne : Needs
{

	// Use this for initialization
	void Start()
	{
		Wc();
	}

	// Update is called once per frame
	public void Wc()
	{

	}
	void OnTriggerStay(Collider other)
	{
		//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		print("kleen");
		if (other.tag == "Player")
		{
			slider.value += moreTime * Time.deltaTime;

		}
	}


}
