using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    public DineroManager dineroManager;

    public void UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            
        }
        else
        {
            playerMoney += amount;
        }
    }
}
