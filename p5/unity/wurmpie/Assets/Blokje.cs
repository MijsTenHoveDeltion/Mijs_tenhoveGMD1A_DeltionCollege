using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blokje : MonoBehaviour
{
	public List<GameObject> food = new List<GameObject>();
	public List<Vector3> nupos = new List<Vector3>();
	//public List<Vector3> oldpos = new List<Vector3>();
	public GameObject Gm;
	public GameObject tail;

	public void Start()
	{
		nupos.Add(Gm.transform.position);
	}

	private void Update()
	{
		Look();
	}

	public void Look()
	{
		for (int i = 0; i < food.Count; i++)
		{
			//nupos[i] = Gm.transform.position;
			//nupos.Add(food[i].transform.position);
			
				if (i != food.Count - 1)
				{
				food[i + 1].gameObject.transform.position = nupos[i];

					//food[j + 1].transform.position = oldpos[j];
					//	print("c2");

				}
				nupos[i] = food[i].transform.position ;

		}

	}


	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{

			print("col");
			Destroy(other.gameObject);
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.tag = ("Pick Up");
			float num = Random.Range(-30, 30);
			float num2 = Random.Range(15, -15);
			cube.transform.position = new Vector3(num, num2, 0);

			GameObject taill = GameObject.CreatePrimitive(PrimitiveType.Cube);
			food.Add(taill);
			taill.tag = "a";


			tail = taill;
			taill.transform.position = new Vector3(1f, 0f, 0f);

			nupos.Add(tail.transform.position);
		}
		if (other.gameObject.CompareTag("a"))
		{
			SceneManager.LoadScene("snake");
			print("hp");
		}
	}

}
