using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
	Menu menu;
	

	public void OnCollisionEnter2D(Collision2D colli)
	{
		if (colli.gameObject.tag == "note")
		{
			Destroy(colli.gameObject);
		}
	   if (colli.gameObject.tag == "Dead")
			{
			print("col");
			SceneManager.LoadScene(0);
			Destroy(colli.gameObject);
			}
	}



}
