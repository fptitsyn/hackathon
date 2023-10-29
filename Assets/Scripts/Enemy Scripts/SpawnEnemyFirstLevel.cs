using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour{
    public GameObject[] waypoints;
    [SerializeField] Castle castle;
    [SerializeField] Enemy[] enemies;

    private void OnMouseDown()
    {
        Spawn();
    }

    public void Spawn(){
        /*
        for(int i = 0;i < enemies.Length; i++){
            FollowWaypoints followWaypoint = new FollowWaypoints();
            followWaypoint.enemy = Instantiate(enemies[i], this.transform.position, this.transform.rotation);
            followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            followWaypoint.enemy.GetComponent<FollowWaypoints>().castle = castle;
        }
        */
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemyToSpawn = tab.currentEnemySelected;
        FollowWaypoints followWaypoint = new FollowWaypoints();
        followWaypoint.enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
        followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        followWaypoint.enemy.GetComponent<FollowWaypoints>().castle = castle;
    }
}
