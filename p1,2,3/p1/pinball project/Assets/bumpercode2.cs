using UnityEngine;
using System.Collections;

public class bumpercode2 : MonoBehaviour {
    //voor de coordinnaten
    public Vector3 dir;
    // voor het rigidbody 
    public Rigidbody bal;

    public void OnCollisionEnter(Collision collision)
    {



        // zorgt voor force (het weg bumpen van de ball)
      
        dir = collision.contacts[0].point;
        bal.AddForce(dir * -1000);
	}
}
