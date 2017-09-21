using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUP : MonoBehaviour
{
	public Scene scene;

	public void Start()
	{
		scene = SceneManager.GetActiveScene();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			
			other.gameObject.SetActive(false);

			Application.LoadLevel(Application.loadedLevel);

		}
	}
}
