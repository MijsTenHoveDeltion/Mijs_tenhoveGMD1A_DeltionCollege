using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : MonoBehaviour
{
	
	public float health = 50f;
	public float speed;


	public void Update()
	{
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	public void TakeDamage(float amount)
	{
		health -= amount;
		if (health <= 0f)
		{
			Destroy(gameObject);
		}


	}
	void OnCollisionEnter(Collision other)
	{


		if (other.gameObject.CompareTag("car"))
		{

			Destroy(other.gameObject);
			Destroy(this.gameObject);

		}
	}


}
