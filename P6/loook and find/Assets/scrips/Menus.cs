using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
	public bool hintready;
	public List<GameObject> partical = new List<GameObject>();

	public GameObject canvas;


	public Image gm;
	public Color green;
	public Color white;

	void Start()
	{
		gm.color = white;
		hintready = false;
		StartCoroutine("Waitforgreen");
	}

	void Update()
	{



	}

		public void reload()
	{
		SceneManager.LoadScene(0);

	}

	public void Aan()
	{
		canvas.SetActive(true);
	}
	public void Uit()
	{
		canvas.SetActive(false);
	}
	public void Quity()
	{
		Application.Quit();
	}

	public void Hintje()
	{

		if (hintready == true)
		{
			
			int randomIndex = Random.Range(0, partical.Count);
			partical[randomIndex].SetActive(true);

			gm.color = white;
		    hintready = false;

			StartCoroutine("Waitforasecond");
			StartCoroutine("Waitforgreen");
			print("hint klik ");
		}
		
		
	}

	IEnumerator Waitforasecond()
	{
		yield return new WaitForSeconds(5);

		for (int i = 0; i < partical.Count; i++)
		{
			partical[i].SetActive(false) ;
		}

		print("yaas");
	}
	IEnumerator Waitforgreen()
	{
		yield return new WaitForSeconds(6);


		gm.color = green;
		hintready = true;
		print("greenn");

	}
}
