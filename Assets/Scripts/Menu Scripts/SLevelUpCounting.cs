using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLevelUpCounting : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {

        int countSpider = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countSpider + 1);


        int maxSpiderHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxSpiderHP + 5);

        int costSpider = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costSpider + 1);

    }
}
