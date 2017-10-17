using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public GameObject gm;
	public float speed;
	public float lookfast = 1.0f;
	private Transform owntransform;
	public float minsensitivity = 30f;
	public float maxsensitivity = 60f;


	// Use this for initialization
	void Start()
	{
		owntransform = gameObject.transform;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		//rotatie
		float roLeftRight = Input.GetAxis("Horizontal") * 90;
		float roUpDown = Input.GetAxis("Vertical")* 90;
		owntransform.Rotate(new Vector3( 0,0, roLeftRight));
		gm.transform.Rotate(0, 0,-roUpDown);

		//move
		float xspeed = Input.GetAxis("Horizontal") * speed;
		float yspeed = Input.GetAxis("Vertical") * speed;
		Vector2 fast = new Vector2(xspeed, yspeed);
		transform.Translate(xspeed, 0, 0);
		transform.Translate(0, yspeed,0);
	}
}


