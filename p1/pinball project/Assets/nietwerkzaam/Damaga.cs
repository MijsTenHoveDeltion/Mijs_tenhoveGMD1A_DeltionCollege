using UnityEngine;
using System.Collections;

public class Damaga : MonoBehaviour {

    // code die nit werkt 

    public class ballstart
    {
     public int Health = 4;  
    }

   // public Playerstats playerstats = new Playerstats();

    public int fallboudary = -20;

    void Update()
    {
        if (transform.position.y <= fallboudary)
        {
            Destroy(gameObject);
        }
            
    }

   // public void Damageplayer(int damage)
   // {
     //   playerstats.Health -= damage;
     //   if (playerstats.Health <= 0)
      //  {
    //        GameMaster.KillPlayr(this);
     // /  }
  //  }
}

