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
	public GameObject bullt;
	public GameObject sound;

	void Update()
	{
		RaycastHit hiting;

		Ray shootray = new Ray(transform.position, Vector3.up);
		Debug.DrawRay(transform.position, Vector3.up * range);

		if (Input.GetButtonDown("Fire1"))
		{

			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
			Destroy(Temporary_Bullet_Handler, 5.0f);

			Instantiate(sound);

			Debug.DrawRay(transform.position, Vector3.up, Color.green);
			if (Physics.Raycast(shootray, out hiting, range))
			{

				Debug.Log(hiting.transform.name);


				//Bad bad = hiting.transform.GetComponent<Bad>();
			//	if (bad != null)
			//	{
				//	bad.TakeDamage(damige);
				//}

			}
		}
	}
	
}


