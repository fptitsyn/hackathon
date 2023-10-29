using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 10;
    public int damage;
    public GameObject target;
    public Vector3 startPosition;
    public Vector3 targetPosition;

    private float distance;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
        distance = Vector2.Distance(startPosition, targetPosition);
    }

    private void Update()
    {
        float timeInterval = Time.time - startTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * speed / distance);

        if (gameObject.transform.position.Equals(targetPosition))
        {
            if (target != null)
            {
                Transform healthBarTransform = target.transform.Find("HealthBar");
                HealthBar healthBar = healthBarTransform.gameObject.GetComponent<HealthBar>();
                healthBar.enemy.currentHP -= Mathf.Max(damage, 0);

                if (gameObject.tag.Equals("Ice"))
                {
                    
                }
                if (healthBar.enemy.currentHP <= 0)
                {
                    Destroy(target);
                }
            }
            Destroy(gameObject);
        }
    }
}
