using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float speed;
	public float amount;
	Bad bad;
	EnemieSpawn es;
	public GameObject expolsion;
	public GameObject bang;

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision other)
	{


		if (other.gameObject.CompareTag("zombie"))
		{
			Instantiate(bang);
			Destroy(bang, 1.0f);
			Instantiate(expolsion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			Destroy(this.gameObject);




			Score.counit += 1;
			print("dg");
		}
	}
}



