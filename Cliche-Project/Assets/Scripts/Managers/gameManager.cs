using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;

    public static gameManager instance;

    void Awake()
    {
        instance = this;
    }

    public void addGold(int amount)
    {
        gold += amount;
        goldText.text = gold.ToString();
    }

    public void removeGold(int amount)
    {
        gold -= amount;
        goldText.text = gold.ToString();
    }

}
