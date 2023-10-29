using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] waypoints;
    [SerializeField] private Castle castle;
    private List<Enemy> _enemies = new List<Enemy>();
    
    private void OnMouseDown()
    {
        Spawn();
    }

    private void Spawn()
    {
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemyToSpawn = tab.currentEnemySelected;
        Enemy enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
        _enemies.Add(enemy);
    }

    public void MoveEnemies()
    {
        foreach (var enemy in _enemies)
        {
            enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            enemy.GetComponent<FollowWaypoints>().castle = castle;
        }
    }
}
