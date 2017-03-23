using UnityEngine;
using System.Collections;

public class Tellen : MonoBehaviour {
    public int Een ;
    public int twee ;
    public int drie ;




    public void MoveForwart( int Een, int twee)
    {
        drie = Een + twee;

    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Getal();

            MoveForwart(Een, twee);

        }
       
    }
    public void Getal()
    {
        Een = Random.Range(1, 10);
        twee = Random.Range(2, 20);

    }
}
