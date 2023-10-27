using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootEnemies : MonoBehaviour
{
    public List<GameObject> enemiesInRange;

    public GameObject bullet;
    private float lastShotTime;

    private void Start()
    {
        enemiesInRange = new List<GameObject>();
        lastShotTime = Time.time;
    }

    private void Update()
    {
        GameObject target = null;
        foreach (var enemy in enemiesInRange)
        {
            target = enemy;
        }

        if (target != null)
        {
            if (Time.time - lastShotTime > 1)
            {
                Shoot(target.GetComponent<Collider2D>());
                lastShotTime = Time.time;
            }

            Vector3 direction = gameObject.transform.position - target.transform.position;
            gameObject.transform.rotation = Quaternion.AngleAxis(
                Mathf.Atan2(direction.y, direction.x) * 180 / Mathf.PI,
                new Vector3(0, 0, 1)
            );
        }
    }

    void OnEnemyDestroy(GameObject enemy)
    {
        enemiesInRange.Remove(enemy);
    }

    void Shoot(Collider2D target)
    {
        Vector3 startPos = gameObject.transform.position;
        Vector3 targetPos = target.transform.position;
        var position = bullet.transform.position;
        startPos.z = position.z;
        targetPos.z = position.z;

        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = startPos;
        BulletBehaviour bulletComp = newBullet.GetComponent<BulletBehaviour>();
        bulletComp.target = target.gameObject;
        bulletComp.startPosition = startPos;
        bulletComp.targetPosition = targetPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            enemiesInRange.Add(other.gameObject);
            var del = other.gameObject.GetComponent<EnemyDestructionDelegate>();
            del.enemyDelegate += OnEnemyDestroy;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            enemiesInRange.Remove(other.gameObject);
            var del = other.gameObject.GetComponent<EnemyDestructionDelegate>();
            del.enemyDelegate -= OnEnemyDestroy;
        }
    }
}
