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
        
        if (PlayerPrefs.HasKey("FirstStart") == false)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("FirstStart", 1);
        }
        
        if (PlayerPrefs.HasKey("maxZombieHP") == false)
        {
            PlayerPrefs.SetInt("maxZombieHP", 100);
        }
        
        if (PlayerPrefs.HasKey("cost") == false)
        {
            PlayerPrefs.SetInt("cost", 5);
        }
        
        StaticUpdate();
    }

    void Update(){
        if (currentHP <= 0)
            Destroy(gameObject);
    }

    public void StaticUpdate()
    {
        maxHP = PlayerPrefs.GetInt("maxZombieHP");
        cost = PlayerPrefs.GetInt("cost");
    }
}
