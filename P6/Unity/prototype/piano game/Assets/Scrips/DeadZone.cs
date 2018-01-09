using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
	Menu menu;

	public void OnCollisionEnter2D(Collision2D colli)
	{
		if (colli.gameObject.tag == "note")
		{
			print("col");
			Destroy(colli.gameObject);
		}
	}

}
