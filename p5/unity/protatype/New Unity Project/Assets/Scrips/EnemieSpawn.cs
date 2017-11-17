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

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		More();

	}
	public void More()
	{

		if (zombiecont > zz.Count)
		{

			GameObject Temporary_zombie_Handler;
			Temporary_zombie_Handler = Instantiate(zombie, enemie_Emitter.transform.position, enemie_Emitter.transform.rotation) as GameObject;
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_zombie_Handler.GetComponent<Rigidbody>();
			zz.Add(Temporary_zombie_Handler);
			//zz.Remove(Temporary_zombie_Handler);
			Destroy(Temporary_zombie_Handler, 5.0f);

			//	transform.Translate(Vector3.up * speed * Time.deltaTime);

		}
	}
	
}
