using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneUpgrade : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {
        int countST = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countST + 1);

        int maxSTHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxSTHP + 50);

        int costST = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costST + 3);
    }
}
