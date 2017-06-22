using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour {

    public Appel appel;
    public Bannana banaan;
	public Fruit fruit;


    public void Start()
    {
		
        appel = new Appel();
        banaan = new Bannana();
        print(appel.rijp);
		//fruit.Pel);
		  

    }
}
