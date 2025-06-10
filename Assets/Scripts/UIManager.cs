using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI healthText;

    void Start()
    {

    }

    public void UpdateMoneyUI(string moneyAmount)
    {  
        moneyText.text = moneyAmount;
    }

    public void UpdateHealthUI(string damageAmount)
    {  
        healthText.text = damageAmount;
    }
}