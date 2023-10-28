using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour{
    [SerializeField] public Enemy enemy;
    private float originalScale;

    private void Start(){
        originalScale = gameObject.transform.localScale.x;
    }

    private void Update(){
        var o = gameObject;
        Vector3 tmpScale = o.transform.localScale;
        tmpScale.x = enemy.currentHP / enemy.maxHP * originalScale;
        o.transform.localScale = tmpScale;
    }
}
