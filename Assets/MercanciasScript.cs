using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciasScript : MonoBehaviour
{
    public int scorePoints;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
