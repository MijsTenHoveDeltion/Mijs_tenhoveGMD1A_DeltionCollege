using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public float damige;
	public float range;

	public GameObject gm;

	public GameObject Bullet_Emitter;
	public GameObject Bullet;
	public float Bullet_Forward_Force;

	
	void Update()
	{
		RaycastHit hiting;

		Ray shootray = new Ray(transform.position, Vector3.up);
		Debug.DrawRay(transform.position, Vector3.up * range);

		if (Input.GetButtonDown("Fire1"))
		{
			
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
			print("a");
			//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
			print("b");
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
			print("c");
			Temporary_RigidBody.AddForce(transform.position * Bullet_Forward_Force);
			//Temporary_RigidBody.velocity = transform.up * Bullet_Forward_Force;
			//Temporary_Bullet_Handler.transform.Translate(Vector3.up * bull);
			print("d");
			Destroy(Temporary_Bullet_Handler, 5.0f);
		

		Debug.DrawRay(transform.position, Vector3.up, Color.green);
			if (Physics.Raycast(shootray, out hiting, range))
			{

				Debug.Log(hiting.transform.name);
				

				Bad bad = hiting.transform.GetComponent<Bad>();
				if (bad!= null)
				{
					bad.TakeDamage(damige);
				}

			}
		}
	}
}


