using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
     GameObject[] enemies;
     
    public Text enemycount;

    void Update()
    {
        
        enemies = GameObject.FindGameObjectsWithTag("enemygroen");

        enemycount.text = "Enemies : " + enemies.Length.ToString();
        




    }
}
