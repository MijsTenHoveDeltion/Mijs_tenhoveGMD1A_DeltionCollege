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
			slider.value += moreTime * Time.deltaTime;
			/*switch (ED)
			{
				case DeEnum.ET:
					print("eten");
					break;
			}
			*/
		}

	}
}
