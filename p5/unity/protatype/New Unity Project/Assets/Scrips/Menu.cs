using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	public GameObject pennelPQ;
	public GameObject pedi;
	// Update is called once per frame
	public void Beck()
	{
		SceneManager.LoadScene(0);

	}

	public void Play()
	{
	SceneManager.LoadScene(0);
	//pennelPQ.SetActive(false);
	//pedi.SetActive(true);
	}
	public void Quit()
	{
		Application.Quit();
	}

	public void Eazy()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	//public void Song1()
	//{
	//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	//}
}

