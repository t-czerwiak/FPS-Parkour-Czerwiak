using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int daño = 10;
    public HealthManager healthManager;

    void Start()
    {   
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthManager.UpdateHealth(-daño))
            {
                Destroy(gameObject);
            }
        }
    }
}
