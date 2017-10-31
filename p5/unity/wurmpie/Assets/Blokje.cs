using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blokje : MonoBehaviour
{
	public List<GameObject> food = new List<GameObject>();
	public List<Vector3> oldpos = new List<Vector3>();
	public GameObject Gm;
	public Vector3 grr;
	public GameObject tail;

	public void Start()
	{
	
	}

	private void Update()
	{
		Look();
	}

	public void Look()
	{
		print("a");
		for (int i = 0; i < food.Count; i++)
		{
			oldpos.Add(Gm.transform.position);
			print("b");
			if (i != food.Count +1 )
			{
				
				print("c");
				food[i].gameObject.transform.position = tail.transform.position;
				food[i + 1].transform.position = oldpos[i];
				

			}
			oldpos[i] = food[i].transform.position;

			print("d");
		}
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			
			print("col");
			Destroy(other.gameObject);
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.tag = ("Pick Up");
			float num = Random.Range(-41, 41);
			float num2 = Random.Range(17, -17);
			cube.transform.position = new Vector3(num, num2, 0);

			GameObject taill = GameObject.CreatePrimitive(PrimitiveType.Cube);
		 
			food.Add(tail);
			tail.transform.position = new Vector3 (0f,0f,0f);

		}
	}

	}
