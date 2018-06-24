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
	public Hint hint;

	void Update()
	{

		hintready = hint.klikbole;
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
		print("0werkt");
		if (hintready == true)
		{
			
			int randomIndex = Random.Range(0, partical.Count);
			partical[randomIndex].SetActive(true);
			hint.gm.color = hint.white;
			hint.klikbole = false;
			StartCoroutine("Waitforasecond");
print("werkt");
			
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
}
