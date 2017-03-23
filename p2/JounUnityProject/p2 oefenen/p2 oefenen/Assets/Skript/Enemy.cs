using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
// werkt niet 
    public int hp = 100;
    public GameObject enemy;

    public void DealDamage(int damage)
    { 
   hp -= damage;
        print(hp); }
	
	// Update is called once per frame
	void Update () {
		
        if(hp <= 0)
        {
            Destroy(enemy);
        }
	}
}

