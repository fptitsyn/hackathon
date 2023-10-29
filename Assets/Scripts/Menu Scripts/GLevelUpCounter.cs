using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {

        int countGolem = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countGolem + 1);


        int maxGolemHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxGolemHP + 50);

        int costGolem = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costGolem + 3);

    }
}
