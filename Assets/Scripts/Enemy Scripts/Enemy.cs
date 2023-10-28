using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    [SerializeField] public int maxHP;
    public int currentHP = 0;
    [SerializeField] public float speed;
    [SerializeField] public int cost;
    [SerializeField] public bool isFly = false;

    private void Start(){
        currentHP = maxHP;
    }

    void Update(){
        if (currentHP <= 0)
            Destroy(this.gameObject);
    }
}
