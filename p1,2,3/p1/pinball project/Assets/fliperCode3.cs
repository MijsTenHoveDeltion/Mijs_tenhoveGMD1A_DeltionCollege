using UnityEngine;
using System.Collections;

public class fliperCode3 : MonoBehaviour {
    // hoeveelheid force
    public float amount2 = 50000f; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //als je liknker pijltje in drukt dan verplaast het objekt
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddTorque
                (transform.forward * -amount2 * Time.deltaTime,ForceMode.Impulse);

        }
        else
        {
            //als je rechter linker in niet in drukt dan verplaast het objekt terug of blijft het staan op de plek waar het stond
            GetComponent < Rigidbody > ().AddTorque
                (transform.forward * amount2 * Time.deltaTime, ForceMode.Impulse);

        }
	}

}
