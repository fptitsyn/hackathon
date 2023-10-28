using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    [SerializeField] public int hp;
    [SerializeField] public float speed;
    [SerializeField] public int cost;
    [SerializeField] public bool isFly = false;

    void Update(){
        if (hp <= 0)
            Destroy(this.gameObject);
    }
}
