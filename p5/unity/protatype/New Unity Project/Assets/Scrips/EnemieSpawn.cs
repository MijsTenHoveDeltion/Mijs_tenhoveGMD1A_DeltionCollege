using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawn : MonoBehaviour
{
	public List<GameObject> zz = new List<GameObject>();
	public float health = 50f;
	public float speed;
	public GameObject enemie_Emitter;

	public GameObject zombie;
	public float zombiecont;
	private IEnumerator coroutine;

	// Use this for initialization
	void Start()
	{
		coroutine = WaitAndPrint(5.0f);
		StartCoroutine(coroutine);

		print("Before WaitAndPrint Finishes " + Time.time);
		

	}


	// every 2 seconds perform the print()
	private IEnumerator WaitAndPrint(float waitTime)
	{
		while (true)
		{
			GameObject Temporary_zombie_Handler;
			Temporary_zombie_Handler = Instantiate(zombie, enemie_Emitter.transform.position, enemie_Emitter.transform.rotation) as GameObject;
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_zombie_Handler.GetComponent<Rigidbody>();
			
			Destroy(Temporary_zombie_Handler, 5.0f);


			yield return new WaitForSeconds(waitTime);
			print("WaitAndPrint " + Time.time);
		}
	}


}




