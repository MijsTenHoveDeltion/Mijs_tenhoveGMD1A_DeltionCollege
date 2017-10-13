using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lijnen : MonoBehaviour
{
	  List<Vector3> particalPosision = new List<Vector3>();
	public List<LineRenderer> linerend = new List<LineRenderer>();

	public ParticleSystem pSystem;
	ParticleSystem.Particle[] m_Particles;
	public LineRenderer lineRender;
	public GameObject gm;

	public int maxPart;
	public float startLife;
	public float startsize;
	public float maxDistence;

	public int line;
	public int pcount;
	public int gelijk;

	void Start()
	{
		//lineRender.GetComponent<LineRenderer>();
		Material particleMaterial = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		gm = new GameObject("Particle System");
		gm.transform.Rotate(-90, 0, 0);
		pSystem = gm.AddComponent<ParticleSystem>();
		gm.GetComponent<ParticleSystemRenderer>().material = particleMaterial;

		var mainModule = pSystem.main;

		mainModule.startColor = Color.blue;
		mainModule.startSize = startsize;
		mainModule.maxParticles = maxPart;
		mainModule.startSpeed = startLife;
		mainModule.simulationSpace = ParticleSystemSimulationSpace.World;

		if (m_Particles == null)
		{
			m_Particles = new ParticleSystem.Particle[maxPart];

		}
	
		var sh = pSystem.shape;
		sh.shapeType = ParticleSystemShapeType.Sphere;
		
	}
	public void LateUpdate()
	{
		
		pSystem.GetParticles(m_Particles);
		pcount = pSystem.particleCount;

		for (int i = 0; i < pcount; i++)
		{
			if (maxPart > 0 && m_Particles[i].position != new Vector3(0f, 0f, 0f))
			{
				Vector3 p1_position = m_Particles[i].position;
				particalPosision.Add(p1_position);



				lineRender.positionCount = pcount;
				gelijk = i;
				lineRender.SetPosition(gelijk, p1_position);



				if (particalPosision[i] != m_Particles[i].position)
				{
					particalPosision.RemoveAt(i);
				}
		
			}
		}
	}
}
// maak new line renderer aan ga door de v3 maar dan random om de kanecties te maken 
// als ditense groter is dan int dan break de line 








