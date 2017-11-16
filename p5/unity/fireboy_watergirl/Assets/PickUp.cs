using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{

	public Scene scene;
	public GameObject gm2;
	public Camera mCam;

	public void Start()
	{
		scene = SceneManager.GetActiveScene();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			Application.LoadLevel(Application.loadedLevel);

		}

		if (other.gameObject.CompareTag("Level2"))
		{

			gm2.transform.position = new Vector3(10f, -1.88f, -2.8f);
			mCam.transform.position = new Vector3(10f, 1.0f, -11.5f);
		}
		if (other.gameObject.CompareTag("Level3"))
		{
			gm2.transform.position = new Vector3(20f, -1.88f, -2.8f);
			//mCam.transform.position = new Vector3(-8f, 1.0f, -11.5f);
		}
	}
}


