using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : Needs
{
	public float moreTime;

	void OnTriggerStay(Collider other)
	{
		//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		if (other.tag == "Player")
		{
			playerskript.ED = Statething.DeEnum.ET;
			slider.value += moreTime * Time.deltaTime;
		
		}

	}
}
