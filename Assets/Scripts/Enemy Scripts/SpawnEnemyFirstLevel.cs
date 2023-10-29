using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] waypoints;
    [SerializeField] private GameObject settings;
    private List<Enemy> _enemies = new List<Enemy>();
    [SerializeField] Castle castle;
    public bool isStarted;
    
    private void OnMouseDown() => Spawn();

    public void Spawn()
    {
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemyToSpawn = tab.currentEnemySelected;
        Enemy enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
        enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        enemy.GetComponent<FollowWaypoints>().castle = castle;
        _enemies.Add(enemy);
    }

    public void MoveEnemies()
    {
        isStarted = true;
        // foreach (var enemy in _enemies)
        // {
        //     enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
        //     enemy.GetComponent<FollowWaypoints>().castle = castle;
        // }
    }
}
