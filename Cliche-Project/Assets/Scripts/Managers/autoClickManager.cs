using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoClickManager : MonoBehaviour
{
    public List<float> autoHireHelp = new List<float>();

    public int autoHireHelpCost;

    public TextMeshProUGUI quantityText;

    void Update()
    {
        for (int i = 0; i < autoHireHelp.Count; i++)
        {
            if(Time.time - autoHireHelp[i] >= 5.0f)
            {
                autoHireHelp[i] = Time.time;
                enemyManager.instance.currentEnemy.Damage();
            }
        }
    }
    public void OnHireHelp()
    {
        if (gameManager.instance.gold >= autoHireHelpCost)
        {
            gameManager.instance.removeGold(autoHireHelpCost);
            autoHireHelp.Add(Time.time);

            quantityText.text = "X" + autoHireHelp.Count.ToString();
        }
    }
}
