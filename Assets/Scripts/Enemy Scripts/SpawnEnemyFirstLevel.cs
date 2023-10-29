using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour{
    public GameObject[] waypoints;
    [SerializeField] private GameObject settings;

    public void Spawn(){
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemy = Instantiate(tab.currentEnemySelected, this.transform.position, this.transform.rotation);
        enemy.AddComponent<FollowWaypoints>();
        enemy.AddComponent<EnemyDestructionDelegate>();
        enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        enemy.GetComponent<FollowWaypoints>().settings = settings;
        Enemy[] oldFollowWaypoints = new Enemy[settings.GetComponent<Level1Script>().enemies.Length];
        for (int i = 0; i < settings.GetComponent<Level1Script>().enemies.Length; i++)
            oldFollowWaypoints[i] = settings.GetComponent<Level1Script>().enemies[i];
        settings.GetComponent<Level1Script>().enemies = new Enemy[settings.GetComponent<Level1Script>().enemies.Length + 1];
        for (int i = 0; i < oldFollowWaypoints.Length; i++)
            settings.GetComponent<Level1Script>().enemies[i] = oldFollowWaypoints[i];
        settings.GetComponent<Level1Script>().enemies[oldFollowWaypoints.Length] = enemy;
   }

    private void OnMouseDown() => Spawn();

    /*
    public void SpawnAllTypes(){
        settings.GetComponent<Level1Script>().enemies = new Enemy[settings.GetComponent<Level1Script>().enemies.Length + enemies.Length];
        for (int i = 0; i < enemies.Length; i++){
            Enemy enemy = Instantiate(enemies[i], this.transform.position, this.transform.rotation);
            enemy.AddComponent<FollowWaypoints>();
            enemy.AddComponent<EnemyDestructionDelegate>();
            enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            enemy.GetComponent<FollowWaypoints>().settings = settings;
            settings.GetComponent<Level1Script>().enemies[i] = enemy;
        }
        //TabPanel tab = FindObjectOfType<TabPanel>();
        //Enemy enemyToSpawn = tab.currentEnemySelected;
        //_enemies.Add(enemyToSpawn);

        //TabPanel tab = FindObjectOfType<TabPanel>();
        //Enemy enemy = Instantiate(tab.currentEnemySelected, transform.position, transform.rotation);
        //enemy.AddComponent<FollowWaypoints>();
        //enemy.AddComponent<EnemyDestructionDelegate>();
        //enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        //enemy.GetComponent<FollowWaypoints>().settings = settings;
        }
    */
    /*
    public void MoveEnemies(){
        settings.GetComponent<Level1Script>().enemies = new Enemy[_enemies.Count];
        foreach (var enemy in _enemies){
            FollowWaypoints followWaypoint = new FollowWaypoints();
            followWaypoint.enemy = Instantiate(enemy, transform.position, transform.rotation);
            followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            followWaypoint.enemy.GetComponent<FollowWaypoints>().settings = settings;
            settings.GetComponent<Level1Script>().enemies[settings.GetComponent<Level1Script>().enemies.Length - 1] = enemy;
        }
    }*/
}
