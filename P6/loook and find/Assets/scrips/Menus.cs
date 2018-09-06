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

	public void SetNull(GameObject toremove )
	{
		for (int i = 0; i < partical.Count; i++)
		{
			if (partical[i] == toremove)
			{
				partical[i] = null;
			}
		}
	}

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
			//Destroy.partical.[randomIndex];
			gm.color = white;
		    hintready = false;

			StartCoroutine(Waitforasecond());
			StartCoroutine(Waitforgreen());
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

		
	}
	IEnumerator Waitforgreen()
	{
		yield return new WaitForSeconds(10);

		List<int> index = new List<int>();
		for (int i = 0; i < partical.Count; i++)
		{
			if (partical[i] == null)
			{
				print("part is snull");
				//Destroy(partical[i]);
				index.Add(i);
			}
		}

		if (index.Count != 0)
		{
			for (int i = index.Count -1; i >= 0; i--)
			{
				partical.RemoveAt(index[i]);
			}
		}
		


		gm.color = green;
		hintready = true;
		print("greenn");

	}
}
