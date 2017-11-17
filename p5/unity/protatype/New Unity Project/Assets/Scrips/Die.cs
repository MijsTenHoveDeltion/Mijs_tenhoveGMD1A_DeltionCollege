using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.CompareTag("water"))
		{
			SceneManager.LoadScene("zombie");
		}
		if (other.gameObject.CompareTag("zombie"))
		{
			SceneManager.LoadScene("zombie");
		}
	}
}
