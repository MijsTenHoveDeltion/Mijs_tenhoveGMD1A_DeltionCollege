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

        if (Physics.Raycast(transform.position, enemy.transform.position))
        {
           hp -= 10;
        }

        if (Physics.Raycast(transform.position, enemy.transform.position)&& hp<=0)
        {
            Debug.Log("test");
            Destroy(enemy);
        }
        }
	}
