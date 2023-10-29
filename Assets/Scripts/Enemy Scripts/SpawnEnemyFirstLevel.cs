using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] waypoints;
    [SerializeField] private GameObject settings;
    private void OnMouseDown() => Spawn();

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
}
