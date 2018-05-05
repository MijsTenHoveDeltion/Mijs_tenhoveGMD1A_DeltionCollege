using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : Needs
{
	public int inTime;

	void OnTriggerStay(Collider other)
	{//als het gameobject colide met het gameobject en als de slider het niet helemaal vol is. dan "laat je weer op"
		if (other.tag == "Player")
		{
			playerskript.ED = Statething.DeEnum.EN;
			slider.value += inTime * Time.deltaTime;
		

		}
	}
}
