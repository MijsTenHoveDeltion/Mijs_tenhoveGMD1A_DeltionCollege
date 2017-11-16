using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision other)
	{
		print("c");
		if (other.gameObject.CompareTag("water"))
		{

			print("a");
			SceneManager.LoadScene("zombie");
		}
	}
}
