using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRLevelUpCounter : MonoBehaviour
{
    public string product;
    public string product2;
    public string product3;


    public void ProductUpgrade()
    {

        int countGriffin = PlayerPrefs.GetInt(product);
        PlayerPrefs.SetInt(product, countGriffin + 1);


        int maxGriffinHP = PlayerPrefs.GetInt(product2);
        PlayerPrefs.SetInt(product2, maxGriffinHP + 10);

        int costGriffin = PlayerPrefs.GetInt(product3);
        PlayerPrefs.SetInt(product3, costGriffin + 2);

    }
}
