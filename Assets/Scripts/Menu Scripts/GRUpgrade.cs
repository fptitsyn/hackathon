using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRUpgrade : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {
        int countGR = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countGR + 1);

        int maxGRHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxGRHP + 10);

        int costGR = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costGR + 1);
    }
}
