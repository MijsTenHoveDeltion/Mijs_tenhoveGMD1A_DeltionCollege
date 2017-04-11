using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvasklik : MonoBehaviour {
    public UIM_Talk uimt;

    void OnMouseDown()
    {
        uimt.Canvasklije(gameObject);
    }
}
