using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	public float speed;
	public float amount;
	Bad bad;
	EnemieSpawn es;
	
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.up * speed* Time.deltaTime);
	}

	void OnCollisionEnter(Collision other)
	{
		

		if (other.gameObject.CompareTag("zombie"))
		{
		
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		
		}
	}
}

