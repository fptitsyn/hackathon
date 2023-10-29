using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;
    public int maxZombieHP = 100;
    public int cost = 5;
    

    public void ProductUpgrade()
    {
        int count = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, count + 1);
        
        PlayerPrefs.SetInt(product2, maxZombieHP + 20);
        maxZombieHP = PlayerPrefs.GetInt(product2);
        
        PlayerPrefs.SetInt(product3, cost + 1);
        cost = PlayerPrefs.GetInt(product3);
        
    }
}
