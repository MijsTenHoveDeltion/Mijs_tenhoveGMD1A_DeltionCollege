using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public bool hit;
   public void OnCollisionEnter(Collision other)
    {
        print("1");
        if (other.gameObject.tag == ("ugh"))
        {
            print("2");
            other.gameObject.GetComponent <ListKey>().opje.Add(gameObject);
            gameObject.SetActive(false);
        }
    }
}