using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lijnen : MonoBehaviour
{
	 List<Vector3> particalPosision = new List<Vector3>();
	
	//List<LineRenderer> lineRenderers = new List<LineRenderer>();


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

	void Start()
	{
		lineRender.GetComponent<LineRenderer>();
		Material particleMaterial = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		gm = new GameObject("Particle System");
		gm.transform.Rotate(-90, 0, 0);
		pSystem = gm.AddComponent<ParticleSystem>();
		gm.GetComponent<ParticleSystemRenderer>().material = particleMaterial;

		var mainModule = pSystem.main;

		mainModule.startColor = Color.blue;
		mainModule.startSize = startsize;
		mainModule.maxParticles = maxPart;
		mainModule.startLifetime = startLife;

		if (m_Particles == null)
		{
			m_Particles = new ParticleSystem.Particle[maxPart];

		}
		//|| m_Particles.Length < maxPart

		var sh = pSystem.shape;
		sh.shapeType = ParticleSystemShapeType.Sphere;

	}


	public void LateUpdate()
	{
		
		pSystem.GetParticles(m_Particles);
		pcount = pSystem.particleCount;

		if (pcount < 10  )
			{

			// elker keer pcount teld er een bij op maak een list new list aan en zet daar de v3 in
				print("h");
			}
		for (int i = 0; i < pcount; i++)
		{
			
			if (maxPart > 0 && m_Particles[i].position != new Vector3(0f, 0f, 0f))
			{

				Vector3 p1_position = m_Particles[i].position;
				particalPosision.Add(m_Particles[i].position);

				for (int j = i; j < pSystem.particleCount; j++)
				{
					if (maxPart > 0 && m_Particles[i].position != new Vector3(0f, 0f, 0f)){}

					particalPosision.Add(m_Particles[j].position);

						Vector3 p2_position = m_Particles[j].position;

						lineRender.SetPosition(0, p1_position);
						lineRender.SetPosition(1, p2_position);
				}
			}
		}
	}
	//				
	//	lineRender.SetPosition(1, p2_position);
	//float dis = Vector3.SqrMagnitude(p1_position - p2_position);

	}






