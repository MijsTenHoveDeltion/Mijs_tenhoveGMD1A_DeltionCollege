using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Camera cam;
	public float speed;
	public float jumpRange;
	public bool onGround;
	public GameObject gm;
	public GameObject ob;
	public Rigidbody rbPlayer;


	public void Start()
	{
		rbPlayer = GetComponent<Rigidbody>();
		onGround = true;
	}

	public void Update()
	{
		float speedH = Input.GetAxis("Horizontal") * speed;
		transform.Translate(speedH, 0.0f, 0.0f);

		if (Input.GetButtonDown("Jump") && onGround == true)
		{
			rbPlayer.velocity += new Vector3(0, jumpRange, 0);
			onGround = false;
		}

		Ray rays = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hiting;


		if (Physics.Raycast(rays, out hiting))
		{
			Vector3 pos = hiting.point;

			gm.transform.position = (new Vector3(pos.x, pos.y, -6));
			ob.transform.position = (new Vector3(pos.x, pos.y, -6));

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
