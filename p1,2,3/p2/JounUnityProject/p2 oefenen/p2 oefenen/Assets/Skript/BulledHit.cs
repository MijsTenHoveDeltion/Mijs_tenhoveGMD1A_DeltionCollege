using UnityEngine;
using System.Collections;

public class BulledHit : MonoBehaviour {
    public GameObject enemy;
    public int hp = 10; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // geeft schade aan game opject 
        if (Physics.Raycast(transform.position, transform.forward)&& Input.GetButtonDown("Fire1"))
        {
           hp -= 10;
            print("test");
        }

        if (Physics.Raycast(transform.position, enemy.transform.position)&& hp<=0)
        {
            Debug.Log("test");
            Destroy(enemy);
        }
        }
	}
