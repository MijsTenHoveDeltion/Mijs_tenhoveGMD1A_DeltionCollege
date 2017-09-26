using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lijnen : MonoBehaviour
{
    public ParticleSystem pSystem;
	ParticleSystem.Particle[] m_Particles;
	public float maxPart;
	public GameObject gm;
	public Mesh m;
	
	//public float maxDistence;
	//public float masLines;
	

	void Start()
	{
		// A simple particle material with no texture.
		Material particleMaterial = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));

		// Create a green particle system.
		gm = new GameObject("Particle System");
		gm.transform.Rotate(-90, 0, 0);
		pSystem = gm.AddComponent<ParticleSystem>();
		gm.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
		var mainModule = pSystem.main;
		mainModule.startColor = Color.blue;
		mainModule.startSize = 0.5f;

		var sh = pSystem.shape;
		sh.shapeType = ParticleSystemShapeType.Sphere;
		//sh.mesh = m;


		//de hoeveelhijd particals
		//maxPart = mainModule.maxParticles;
		//m_Particles = new ParticleSystem.Particle[system.maxParticles];



	}
	public void Update()
	{
		for (int i = 0; i < 0; i++)
		{
			
		}
		// maak een list met particals laat in de loop zien waar ze zitten maak dan het de berekening tussen elkaar 
	}

}

// partical.posision = ... dicht bij dan maak lijn 
// partical systeem / partical efect
//maxParticles
