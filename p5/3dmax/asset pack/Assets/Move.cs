using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	public Camera mainCam;
	public float speed;
	public float lookfast = 1.0f;
	private Transform owntransform;
	public float minsensitivity = 30f;
	public float maxsensitivity = 60f;


	// Use this for initialization
	void Start()
	{
		Cursor.lockState = CursorLockMode.Confined;
		owntransform = gameObject.transform;


	}

	// Update is called once per frame
	void FixedUpdate()
	{
		//rotatie
		float roLeftRight = Input.GetAxis("Mouse X") * lookfast * Time.deltaTime;
		float roUpDown = Input.GetAxis("Mouse Y");
		owntransform.Rotate(new Vector3(roLeftRight,0,0  ));
		mainCam.transform.Rotate(-roUpDown, 0, 0);

		//move
		float xspeed = Input.GetAxis("Horizontal") * speed;
		float yspeed = Input.GetAxis("Vertical") * speed;
		Vector3 fast = new Vector3(xspeed, 0, yspeed);
		transform.Translate(xspeed, 0, 0);
		transform.Translate(0, 0, yspeed);
	}
}
