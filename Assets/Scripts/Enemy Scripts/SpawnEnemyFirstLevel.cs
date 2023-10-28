using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour{
    public GameObject[] waypoints;
    [SerializeField] Castle castle;
    [SerializeField] Enemy[] enemies;

    private void Start(){
        for(int i = 0;i < enemies.Length; i++){
            FollowWaypoints followWaypoint = new FollowWaypoints();
            followWaypoint.enemy = Instantiate(enemies[i], this.transform.position, this.transform.rotation);
            followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            followWaypoint.enemy.GetComponent<FollowWaypoints>().castle = castle;/*
            for(int j = 0;j < waypoints.Length; j++){
                followWaypoint.waypoints[j] = Instantiate(waypoints[j]);
                Debug.Log(waypoints[j]);
                Debug.Log(followWaypoint.waypoints[j]);
            }*/
        }
    }
}
