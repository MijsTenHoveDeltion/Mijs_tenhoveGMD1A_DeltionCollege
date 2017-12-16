using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaySpawn : MonoBehaviour
{

	
	public float speed;
	public GameObject enemie_Emitter;
	public GameObject zombie;
	private IEnumerator coroutine;

	float randx;
	Vector2 wheretospawn;

	public float manny;
	public float mannymore;
	public float stard;

	// Use this for initialization
	void Start()
	{
		coroutine = WaitAndPrint(stard);
		StartCoroutine(coroutine);
	}

	private IEnumerator WaitAndPrint(float f)
	{
		while (true)
		{
			GameObject Temporary_zombie_Handler;

			randx = this.gameObject.transform.position.x;
			wheretospawn = new Vector2(randx, transform.position.y);

			Temporary_zombie_Handler = Instantiate(zombie, wheretospawn, enemie_Emitter.transform.rotation) as GameObject;
			Destroy(Temporary_zombie_Handler, 10.0f);
			yield return new WaitForSeconds(Random.Range(manny,mannymore));
			
		}
		
	}
	
}
