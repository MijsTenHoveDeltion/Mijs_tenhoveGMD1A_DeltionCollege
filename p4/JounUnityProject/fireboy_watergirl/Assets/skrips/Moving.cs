using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public Camera cam;
	public float speed;
	public float jumpRange;
	public bool onGround;
	public GameObject gm;
	public Rigidbody rbPlayer;
	

	public void Start()
	{
		rbPlayer = GetComponent<Rigidbody>();
		onGround = true;
	}

	public void Update ()
	{
		float speedH = Input.GetAxis("Horizontal") * speed;
		transform.Translate(speedH,0.0f, 0.0f );

		if  (Input.GetButtonDown("Jump") && onGround == true)
		{	
			rbPlayer.velocity += new Vector3(0, jumpRange, 0);
			onGround = false;
		}

		if (Input.GetButton("Fire1"))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				Vector3 pos = hit.point;
				gm.transform.position = (new Vector3(pos.x ,pos.y,-5));
			}
		}
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.position.y < transform.position.y)
		{
			
			onGround = true;
		}
	}


}
