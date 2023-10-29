using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePrefabs : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;

    public void UpdateAll()
    {
        

        if ((PlayerPrefs.HasKey("start") == false))
        {
            int start = PlayerPrefs.GetInt(product);
            PlayerPrefs.SetInt(product, start + 1);

            int maxZombieHP = 80;
            maxZombieHP = PlayerPrefs.GetInt(product2, maxZombieHP);
            PlayerPrefs.SetInt(product2, maxZombieHP + 20);

            int cost = 5;
            PlayerPrefs.SetInt(product3, cost + 1);
        }
        else
        {
            Debug.Log("lsdldllds");
        }
        
    }
}
