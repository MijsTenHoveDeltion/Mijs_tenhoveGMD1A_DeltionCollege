using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WekkerManager : MonoBehaviour
{
    public Wekker wekker;
    public List <Wekker> listwekkers = new List <Wekker>();


    public void Klik()
    {
        
        wekker = new Wekker();
        for (int i= 0; i< 10; i++)
        {
            listwekkers.Add(wekker) ;
            StartCoroutine(listwekkers[i].Time(Random.Range (0, 10)));
        }
        // in mijn wekkermanerger moet ik als ik klik dan haal dat op
   

    }


    void Update()
    {
     
    }
}
    