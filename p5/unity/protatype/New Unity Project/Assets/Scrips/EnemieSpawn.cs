using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawn : MonoBehaviour
{
	public float health = 50f;
	public float speed;
	public GameObject enemie_Emitter;
	public GameObject zombie;
	private IEnumerator coroutine;

	float randx;
	Vector2 wheretospawn;

	public float manny;

	// Use this for initialization
	void Start()
	{
		coroutine = WaitAndPrint(manny);
		StartCoroutine(coroutine);

		//print("Before WaitAndPrint Finishes " + Time.time);
		

	}

	


	// every 2 seconds perform the print()
	private IEnumerator WaitAndPrint(float waitTime)
	{
		while (true)
		{
			GameObject Temporary_zombie_Handler;

			randx = Random.Range (-8.0f, 8.0f);
			wheretospawn = new Vector2(randx, transform.position.y);

			Temporary_zombie_Handler = Instantiate(zombie, wheretospawn, enemie_Emitter.transform.rotation) as GameObject;
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_zombie_Handler.GetComponent<Rigidbody>();
			Destroy(Temporary_zombie_Handler, 5.0f);


			yield return new WaitForSeconds(waitTime);
			//print("WaitAndPrint " + Time.time);
		}
	}


}




