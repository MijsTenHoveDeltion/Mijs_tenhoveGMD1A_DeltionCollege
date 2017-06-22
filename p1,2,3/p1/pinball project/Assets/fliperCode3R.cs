using UnityEngine;
using System.Collections;

public class fliperCode3R : MonoBehaviour
{
    // hoeveelheid force
    public float amount = 50000f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //als je rechte pijltje in drukt dan verplaast het objekt
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddTorque
                (transform.forward * amount * Time.deltaTime, ForceMode.Impulse);

        }
        else
        {
            //als je rechter linker in niet in drukt dan verplaast het objekt terug of blijft het staan op de plek waar het stond
            GetComponent<Rigidbody>().AddTorque
                (transform.forward * -amount * Time.deltaTime, ForceMode.Impulse);

        }
    }

}
