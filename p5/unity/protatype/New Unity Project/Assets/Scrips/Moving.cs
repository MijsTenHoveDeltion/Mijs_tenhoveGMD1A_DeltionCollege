﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public float speed ;
	private Vector3 targetPosition;
	private bool isMoving;
	public GameObject clickAnimation;


	void Update()
	{
		targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		targetPosition.z = transform.position.z;

		if (isMoving == false)
		{
				isMoving = true;
			
		}
		
		if (isMoving == true)
		{

			transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
		}
		if (targetPosition == transform.position)
		{
			isMoving = false;
			Destroy(GameObject.Find("Click Animation(Clone)"));
		}
	}
}