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
    }

    void Update(){
        if (currentHP <= 0)
            Destroy(this.gameObject);
    }

    public void StaticUpdate()
    {
        maxHP = PlayerPrefs.GetInt("maxZombieHP");
        cost = PlayerPrefs.GetInt("cost");
    }
}
