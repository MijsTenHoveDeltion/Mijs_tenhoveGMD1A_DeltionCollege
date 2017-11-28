using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AanUit : MonoBehaviour
{
	public GameObject penel;

	public void OpenPenel()
	{
		penel.SetActive(true);

	}

	public void ClosePenel()
	{
		penel.SetActive(false);
	}
}
