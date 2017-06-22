using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolitieManager : MonoBehaviour {
    public Moeilijk moeilijk;

    public void Start()
    {
        moeilijk = new Moeilijk();
        print(moeilijk.boos == true);
    }
}
