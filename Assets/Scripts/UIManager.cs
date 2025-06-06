using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public DineroManager dineroManager;
    public TextMeshProUGUI moneyText;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    void Update()
    {
        if (dineroManager && moneyText)
        {
            moneyText.text = "$" + dineroManager.playerMoney.ToString("F2");
        }

        else
        {
            Debug.Log("Error, dineroManager o moneyText no están asignados en UIManager.");
        }
    }
    
}

