using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartklikObject : MonoBehaviour
{
    public StartKlik klik ;

    void OnMouseDown()
    {
        klik.StartKlikObject(gameobject);
    }



}