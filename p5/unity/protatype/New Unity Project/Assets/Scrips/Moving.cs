using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	//public Camera cam;
	public float speed;



	public void Start()
	{
		
	}

	public void Update()
	{

		float speedH = Input.GetAxis("Horizontal") * speed;
		transform.Translate(speedH, 0.0f, 0.0f);
	}
}