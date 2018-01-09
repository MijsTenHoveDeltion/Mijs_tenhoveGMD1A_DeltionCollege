using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adding : MonoBehaviour
{

	//public float speed;
	public GameObject kay;
	public GameObject note;
	//private IEnumerator coroutine;

	float randx;
	Vector2 wheretospawn;
	public string kaay;
	
	public void Update()
	{

		if (Input.GetKeyDown(kaay))
		{
			Spam();
		}
	}


	public void Spam()
	{
			GameObject Temporary_zombie_Handler;

			randx = this.gameObject.transform.position.x;
			wheretospawn = new Vector2(randx, transform.position.y);

			Temporary_zombie_Handler = Instantiate(note, wheretospawn, kay.transform.rotation) as GameObject;
	}

}


