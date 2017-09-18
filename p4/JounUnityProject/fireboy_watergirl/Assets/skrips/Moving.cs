using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public float speed;
	public float jumpRange;
	public bool jumping;
	public GameObject gm;

	public void Start()
	{
		jumping = false;
	}

	public void Update ()
	{
		Debug.DrawRay(transform.position, -transform.up * 100, Color.red);
		RaycastHit hit;
		Ray jumpRay = new Ray(transform.position, Vector3.down); 

		float speedH = Input.GetAxis("Horizontal") * speed;
		transform.Translate(speedH,0.0f, 0.0f );

		if  (jumping == true&&Physics.Raycast(jumpRay, out hit, jumpRange))
		{
			print("c");
			float speedUp = Input.GetAxis("Vertical") * speed;
			transform.Translate(0.0f, speedUp,0.0f );
		}
		
			
	}
	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("floor"))
		{
			print("a"); 
			jumping = true;
		}
		else
		{
			print("b");
			jumping = false;
		}

	}


}
