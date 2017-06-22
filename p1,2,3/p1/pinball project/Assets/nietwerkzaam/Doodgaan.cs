using UnityEngine;
using System.Collections;

public class Doodgaan : MonoBehaviour
{

    public void KillBall(GameObject Ball)
    {
        Destroy(Ball.gameObject);
    }
}