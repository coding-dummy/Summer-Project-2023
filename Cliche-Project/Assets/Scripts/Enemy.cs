using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int currentHp;

    public int maxHp;

    public int goldReward;

    public Image healthBarStatus;

    public void Damage()
    {
        currentHp--;
        healthBarStatus.fillAmount = (float)currentHp / (float)maxHp;

        if(currentHp <= 0)
        {
            Slain();
        }
    }

    public void Slain()
    {
        gameManager.instance.addGold(goldReward);
        enemyManager.instance.replaceEnemy(gameObject);
    }
}
