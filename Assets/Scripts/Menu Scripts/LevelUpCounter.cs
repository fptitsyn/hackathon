using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;
    

    public void ProductUpgrade()
    {
        int countZombie = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countZombie + 1);

        int maxZombieHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxZombieHP + 20);

        int costZombie = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costZombie + 1);
    }
}
