using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lijnen : MonoBehaviour
{
	public List<Vector3> particalPosision = new List<Vector3>();
	public List<Particle> partist = new List<Particle>();

	public ParticleSystem pSystem;
	ParticleSystem.Particle[] m_Particles;
	public LineRenderer lineRender;
	public GameObject gm;

	public int maxPart;
	public float startLife;
	public float startsize;
	public float maxDistence;

	public int sizeList;
	public int pcount;

	void Start()
	{
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
		
		if (m_Particles == null )
		{
			m_Particles = new ParticleSystem.Particle[maxPart];
		
		}
		//|| m_Particles.Length < maxPart

		var sh = pSystem.shape;
		sh.shapeType = ParticleSystemShapeType.Sphere;
	}

	public void Update()
	{
		pcount = pSystem.particleCount;
		for (int i = 0; i < pSystem.particleCount; i++)
		{
				if (maxPart > 0 && m_Particles[pcount].position != null)
			{
				//m_Particles[maxPart].position = new Vector3(
				particalPosision.Add(m_Particles[i].position);
				///	print(pSystem.particleCount);
				//print(m_Particles[maxPart].position);
				
				Vector3 p1_position = m_Particles[i].position;
				print(p1_position);
			}
			if (particalPosision.Count > maxPart * startLife)
			{
				int remove = Mathf.Min(particalPosision.Count, maxPart);
				particalPosision.RemoveRange(0, remove);

				
				//particalPosision.Remove(m_Particles[i].position);
				print("hoi");
			}
		}    
	}
}




