using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollTheBall : MonoBehaviour
{
    public float speed;
	public float kijk;
	public Camera cam;
	private Transform owntrans;
	public GameObject pop;


	void Start()
	{
		owntrans = gameObject.transform;
	}
	void Update()
	{
		

	}
	void FixedUpdate()
	{
		float roUpDown = Input.GetAxis("Mouse Y") * kijk * Time.deltaTime;
		cam.transform.Rotate(-roUpDown, 0, 0);

		float roLeftRight = Input.GetAxis("Mouse X") * kijk;
		//owntrans.Rotate(new Vector3(0, roLeftRight, 0));
		pop.transform.Rotate(0, 0, roLeftRight);

		float speedH = Input.GetAxis("Horizontal") * speed ;
		float speedV = Input.GetAxis("Vertical")* speed; 
		transform.Translate(speedH, speedV,0.0f );
	}
}
