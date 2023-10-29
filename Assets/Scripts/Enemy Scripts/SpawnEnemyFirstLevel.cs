using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour{
    public GameObject[] waypoints;
    [SerializeField] private Enemy[] enemies;
    [SerializeField] private GameObject settings;
    [SerializeField] Castle castle;
    private List<Enemy> _enemies = new List<Enemy>();

    private void OnMouseDown() => Spawn();

    public void Spawn(){
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

    public void MoveEnemies(){
        foreach (var _enemy in _enemies){
            Enemy enemy = Instantiate(_enemy, transform.position, transform.rotation);
            enemy.AddComponent<FollowWaypoints>();
            enemy.AddComponent<EnemyDestructionDelegate>();
            enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            enemy.GetComponent<FollowWaypoints>().settings = settings;
        }
    }
}
