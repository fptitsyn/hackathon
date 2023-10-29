using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WLevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {

        int countWolf = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countWolf + 1);


        int maxWolfHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxWolfHP + 5);

        int costWolf = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costWolf + 1);

    }
}
