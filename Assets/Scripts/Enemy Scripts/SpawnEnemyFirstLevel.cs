using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour{
    public GameObject[] waypoints;
    [SerializeField] Castle castle;
    private List<Enemy> _enemies = new List<Enemy>();
    private void OnMouseDown()
    {
        Spawn();
    }

    private void Spawn(){
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemyToSpawn = tab.currentEnemySelected;
        _enemies.Add(enemyToSpawn);
    }

    public void MoveEnemies()
    {
        foreach (var enemy in _enemies)
        {
            FollowWaypoints followWaypoint = new FollowWaypoints();
            followWaypoint.enemy = Instantiate(enemy, transform.position, transform.rotation);
            followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            followWaypoint.enemy.GetComponent<FollowWaypoints>().castle = castle;
        }
    }
}
