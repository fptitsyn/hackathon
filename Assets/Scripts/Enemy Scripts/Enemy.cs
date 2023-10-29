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
<<<<<<< Updated upstream
=======
        
>>>>>>> Stashed changes
        StaticUpdate();
        StaticUpdateWolf();
        StaticUpdateGolem();
        StaticUpdateSpider();
        StaticUpdateGriffin();
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

        if (PlayerPrefs.HasKey("cost") == false)
        {
            PlayerPrefs.SetInt("cost", 5);
        }

        maxHP = PlayerPrefs.GetInt("maxZombieHP");
        cost = PlayerPrefs.GetInt("cost");
    }

    public void StaticUpdateWolf()
    {
        if (PlayerPrefs.HasKey("maxWolfHP") == false)
        {
            PlayerPrefs.SetInt("maxWolfHP", 20);
        }

        if (PlayerPrefs.HasKey("costWolf") == false)
        {
            PlayerPrefs.SetInt("costWolf", 4);
        }

        maxHP = PlayerPrefs.GetInt("maxWolfHP");
        cost = PlayerPrefs.GetInt("costWolf");
    }

    public void StaticUpdateGolem()
    {
        if (PlayerPrefs.HasKey("maxGolemHP") == false)
        {
            PlayerPrefs.SetInt("maxGolemHP", 250);
        }

        if (PlayerPrefs.HasKey("costGolem") == false)
        {
            PlayerPrefs.SetInt("costGolem", 7);
        }

        maxHP = PlayerPrefs.GetInt("maxGolemHP");
        cost = PlayerPrefs.GetInt("costGolem");
    }

    public void StaticUpdateGriffin()
    {
        if (PlayerPrefs.HasKey("maxGriffinHP") == false)
        {
            PlayerPrefs.SetInt("maxGriffinHP", 70);
        }

        if (PlayerPrefs.HasKey("costGriffin") == false)
        {
            PlayerPrefs.SetInt("costGriffin", 3);
        }

        maxHP = PlayerPrefs.GetInt("maxGriffinHP");
        cost = PlayerPrefs.GetInt("costGriffin");
    }

    public void StaticUpdateSpider()
    {
        if (PlayerPrefs.HasKey("maxSpiderHP") == false)
        {
            PlayerPrefs.SetInt("maxSpiderHP", 15);
        }

        if (PlayerPrefs.HasKey("costSpider") == false)
        {
            PlayerPrefs.SetInt("costSpider", 2);
        }

        maxHP = PlayerPrefs.GetInt("maxSpiderHP");
        cost = PlayerPrefs.GetInt("costSpider");
    }
    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
