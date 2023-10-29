using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPUpgrade : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {
        int countSP = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countSP + 1);

        int maxSPHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxSPHP + 5);

        int costSP = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costSP + 1);
    }
}
