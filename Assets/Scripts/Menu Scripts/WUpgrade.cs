using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WUpgrade : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {
        int countW = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countW + 1);

        int maxWHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxWHP + 5);

        int costW = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costW + 1);
    }
}
