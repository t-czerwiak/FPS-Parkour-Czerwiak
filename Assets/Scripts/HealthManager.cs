using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateHealthUI(playerHealth.ToString());
    }

    public bool UpdateHealth(float amount)
    {
        if (playerHealth + amount < 0)
        {
            return false;
        }
        else
        {
            playerHealth += amount;
            uiManager.UpdateHealthUI(playerHealth.ToString());
            return true;
        }
    }
}
