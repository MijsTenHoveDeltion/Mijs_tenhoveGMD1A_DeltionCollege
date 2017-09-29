using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lijnen : MonoBehaviour
{
	public List<Vector3> particalPosision = new List<Vector3>();
	public List<Particle> particals = new List<Particle>();

	public ParticleSystem pSystem;
	ParticleSystem.Particle[] m_Particles;
	public LineRenderer lineRender;
	public GameObject gm;


	//public Mesh m;
	public int maxPart;
	public float startLife;
	public float startsize;
	public float maxDistence;

	public int sizeList;
	public int pcount;

	void Start()
	{
		sizeList = particalPosision.Count;
		sizeList = maxPart;
		print("c");
		Material particleMaterial = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		gm = new GameObject("Particle System");
		gm.transform.Rotate(-90, 0, 0);
		pSystem = gm.AddComponent<ParticleSystem>();
		gm.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
		
		// m_particle moet een gm hebbben 

		var mainModule = pSystem.main;
		mainModule.startColor = Color.blue;
		mainModule.startSize = startsize;
		mainModule.maxParticles = maxPart;
		mainModule.startLifetime = startLife;

		

		var sh = pSystem.shape;
		sh.shapeType = ParticleSystemShapeType.Sphere;
		//maxPart = mainModule.maxParticles;
	}
	public void Update()
	{


		//pSystem.Particle.posision
		pcount = pSystem.particleCount;

		for (int i = 0; i < pSystem.particleCount; i++)
		{
			print(m_Particles[pcount]);
			print("a");
			if (maxPart > 0 && m_Particles[pcount].position != null)
			{
				
				particalPosision.Add(m_Particles[pcount].position);
				//print(pSystem.particleCount);
			}
			//pcount = i;
			
			//if (m_Particles[0]. != null)
			//{
			//Vector3 iets = m_Particles[maxPart].position;
			//}
		}
	}







	//Vector3 iets = m_Particles[0].position;
	//print(iets);
}
// maak list met particals en elkekeer als er een partelcel te voorschijn komt dan zet hij het in de lis en als hij verdwijnt gaat hij uit de list 
// for doorde list voor de pozietie 
// for2 voor welke het digtst bij elkaar staan



// partical.posision = ... dicht bij dan maak lijn 
// partical systeem / partical efect
//maxParticles
