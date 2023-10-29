using System.Collections.Generic;
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
        _enemies.Add(enemyToSpawn);
        // FollowWaypoints followWaypoint = new FollowWaypoints();
        // followWaypoint.enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
        // followWaypoint.enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        // followWaypoint.enemy.GetComponent<FollowWaypoints>().castle = castle;
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
