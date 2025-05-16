using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnFall : MonoBehaviour
{
    public float deathFallHeight = -15;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y < deathFallHeight)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
