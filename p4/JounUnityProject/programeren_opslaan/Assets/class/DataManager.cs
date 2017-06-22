using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;


public class DataManager : MonoBehaviour
{
	public DataHolder dataHolder;

	void Start()
	{
		dataHolder = new DataHolder();
		//dataHolder.testInt = 100;
		dataHolder = Load();
		//Save(dataHolder);

		//PlayerPrefs.SetInt("testInt", 100);
		print(PlayerPrefs.GetInt("testInt"));
	}

	public void Save(DataHolder toSave)
	{
		var serializer = new XmlSerializer(typeof(DataHolder));
		// var = hout ruimtevrij
		// new XmlSerializer = verhuisman die dingen KAN inpakkel
		// (typeof(DataHolder)) =  laat de verhuisman weten welke kamer hij moet vehuizen 
		using (var stream = new FileStream(Application.dataPath + "/TestSave.xml", FileMode.Create))
		{
			serializer.Serialize(stream, toSave);
		}
		//using = moet een taak doen op een bepaalde manier
		//(var stream = new FileStream = wat er word mee in de ver stream word gestuurd
		//(Application.dataPath//dat het overal kan opslaan en niet aleen op bijv je c schijf//+ "/TestSafe.xml",//maakt bestan moet die naam// FileMode.Create)) waar je moet opslaan en welke type
		//serializer.Serialize(stream, toSave); de verhuisman gaat verhuizen gij veet nu wat hij moet verhuizen en hoe

	}
	public DataHolder Load()
	{
		var serializer = new XmlSerializer(typeof(DataHolder));
	 
		using (var stream = new FileStream(Application.dataPath + "/TestSave.xml", FileMode.Open))
		{
			return serializer.Deserialize(stream) as DataHolder;
		}
		

	}



}
