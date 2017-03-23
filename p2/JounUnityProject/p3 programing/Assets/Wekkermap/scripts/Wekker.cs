using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wekker : MonoBehaviour
{

    public IEnumerator Time(int f)
    {
        yield return new WaitForSeconds(f);
        print("hotty");
    }
      //de list dat moet de strings opgehaald worden
}


