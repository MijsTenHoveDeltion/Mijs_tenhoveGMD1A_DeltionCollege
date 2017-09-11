using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed;
	public float kijk;
	public float scrol;
	public Camera cam;
	public Transform ownTransForm;
	public GameObject gm;

	public void Start()
	{
		ownTransForm = gameObject.transform;
	}

	void FixedUpdate()
	{
		float roUpDown = Input.GetAxis("Mouse Y") * kijk ;
		float roLeftRight = Input.GetAxis("Mouse X") * kijk;
		cam.transform.Rotate(-roUpDown, 0, 0);
		ownTransForm.transform.Rotate(0, 0, roLeftRight);

		float speedH = Input.GetAxis("Horizontal") * speed;
		float speedV = Input.GetAxis("Vertical") * speed;
		transform.Translate(speedV ,0.0f,speedH );

		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			float speedDown = Input.GetAxis("Mouse ScrollWheel") * speed;
			transform.Translate(0, 0, speedDown);
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			float speedUp = Input.GetAxis("Mouse ScrollWheel") * speed;
			transform.Translate(0, 0,speedUp );
		}
	}
}
