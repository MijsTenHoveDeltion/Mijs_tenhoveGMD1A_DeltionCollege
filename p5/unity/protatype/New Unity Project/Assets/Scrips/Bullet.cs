using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed;
	public float damige;
	Bad bad;
	
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.up * speed* Time.deltaTime);
	}

	void OnCollisionEnter(Collision other)
	{
		

		if (other.gameObject.CompareTag("zombie"))
		{
			print(" 2t");
			//if (bad != null)
			//{
				
			if (bad != null)
			{
				print(" abullet");
				bad.TakeDamage(damige);
			}
			//	Destroy(this);
			//}
		}
	}
}

