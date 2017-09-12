using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public float speed;
	public float jumpRange;

	public void Update ()
	{
		Debug.DrawRay(transform.position, -transform.up * 100, Color.red);

		float speedH = Input.GetAxis("Horizontal") * speed;
		transform.Translate(speedH,0.0f, 0.0f );

		//if(Ray => 0)
			float speedUp = Input.GetAxis("Vertical") * speed;
			transform.Translate(0.0f, speedUp,0.0f );
	}


}
