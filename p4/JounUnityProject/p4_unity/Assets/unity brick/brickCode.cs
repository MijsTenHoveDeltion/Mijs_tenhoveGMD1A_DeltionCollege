using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brickCode : MonoBehaviour
{
	public Renderer rendCol;
	public Renderer rend;
	void Start()
	{
		rend = GetComponent<Renderer>();
		rendCol = GetComponent <Renderer>();
	}
	void Update()
	{

		ProceduralMaterial subje= rendCol.sharedMaterial as ProceduralMaterial;
		ProceduralMaterial substance = rend.sharedMaterial as ProceduralMaterial;
		if (substance)
		{
			substance.SetProceduralFloat("BrickCountX", Random.Range(5,10));
			substance.SetProceduralFloat("BrickCountY", Random.Range(5, 10));
			substance.RebuildTextures();	
		}
		if (subje)
		{
			substance.SetProceduralFloat("BrickCountX", Random.Range(5, 100));
			substance.SetProceduralFloat("BrickCountY", Random.Range(5, 100));
			substance.color = Random.ColorHSV();
		}

	}
}