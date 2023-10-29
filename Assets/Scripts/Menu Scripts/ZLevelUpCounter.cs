using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZLevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;
    

    public void ProductUpgrade()
    {
        int count = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, count + 1);
        
        int maxZombieHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxZombieHP + 20);
        
        int cost = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, cost + 1);
        
        
    }
}
