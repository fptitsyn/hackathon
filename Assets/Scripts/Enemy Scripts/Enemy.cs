using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    [SerializeField] public int maxHP;
    public int currentHP = 0;
    [SerializeField] public float speed;
    [SerializeField] public int cost;
    [SerializeField] public bool isFly = false;
    [SerializeField] public int attack = 1;

    private void Start(){
        currentHP = maxHP;
        StaticUpdate();
        StaticUpdateW();
        StaticUpdateST();
        StaticUpdateSP();
        StaticUpdateGR();
    }

    void Update(){
        if (currentHP <= 0)
            Destroy(gameObject);
    }

    public void StaticUpdate()
    {
        if (PlayerPrefs.HasKey("maxZombieHP") == false)
        {
            PlayerPrefs.SetInt("maxZombieHP", 100);
        }

        if (PlayerPrefs.HasKey("costZombie") == false)
        {
            PlayerPrefs.SetInt("costZombie", 5);
        }
        maxHP = PlayerPrefs.GetInt("maxZombieHP");
        cost = PlayerPrefs.GetInt("costZombie");
    }

    public void StaticUpdateW()
    {
        if (PlayerPrefs.HasKey("maxWHP") == false)
        {
            PlayerPrefs.SetInt("maxWHP", 20);
        }

        if (PlayerPrefs.HasKey("costW") == false)
        {
            PlayerPrefs.SetInt("costW", 4);
        }
        maxHP = PlayerPrefs.GetInt("maxWHP");
        cost = PlayerPrefs.GetInt("costW");
    }

    public void StaticUpdateST()
    {
        if (PlayerPrefs.HasKey("maxSPHP") == false)
        {
            PlayerPrefs.SetInt("maxSTHP", 250);
        }

        if (PlayerPrefs.HasKey("costST") == false)
        {
            PlayerPrefs.SetInt("costST", 6);
        }
        maxHP = PlayerPrefs.GetInt("maxSTHP");
        cost = PlayerPrefs.GetInt("costST");
    }

    public void StaticUpdateSP()
    {
        if (PlayerPrefs.HasKey("maxSPHP") == false)
        {
            PlayerPrefs.SetInt("maxSPHP", 15);
        }

        if (PlayerPrefs.HasKey("costSP") == false)
        {
            PlayerPrefs.SetInt("costSP", 2);
        }
        maxHP = PlayerPrefs.GetInt("maxSPHP");
        cost = PlayerPrefs.GetInt("costSP");
    }

    public void StaticUpdateGR()
    {
        if (PlayerPrefs.HasKey("maxGRHP") == false)
        {
            PlayerPrefs.SetInt("maxGRHP", 70);
        }

        if (PlayerPrefs.HasKey("costGR") == false)
        {
            PlayerPrefs.SetInt("costGR", 3);
        }
        maxHP = PlayerPrefs.GetInt("maxGRHP");
        cost = PlayerPrefs.GetInt("costGR");
    }

    public void DelAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
