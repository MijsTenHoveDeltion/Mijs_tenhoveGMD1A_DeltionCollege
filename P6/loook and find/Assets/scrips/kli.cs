using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kli : MonoBehaviour
{
	public bool boo;
	public GameObject imagename;
	public GameObject ob;
	public Tacking tacking;

	public GameObject ps;

	void Start()
	{
		ps.SetActive( false);
		//ps.GetComponent<particleSystem>().enebleEmission = false;
	}

	public void OnMouseDown()
	{
		
		Debug.Log(imagename);
		Destroy(ob);
		Destroy(imagename);
		tacking.kliks += 1;
		//ps.GetComponent<particleSystem>().enebleEmission = true;
		ps.SetActive(true);
		//Instantiate (splase, obplase, splase.rotation);
		//Start(ps);
	}

}
