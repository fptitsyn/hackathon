using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] waypoints;
    [SerializeField] private GameObject settings;
    private List<Enemy> _enemies = new List<Enemy>();
    [SerializeField] Castle castle;
    [SerializeField] private TMP_Text enemyCountText;
    
    public bool isStarted;
    
    private void OnMouseDown() => Spawn();

    public void Spawn()
    {
        TabPanel tab = FindObjectOfType<TabPanel>();
        Enemy enemyToSpawn = tab.currentEnemySelected;
        if (_enemies.Count < 3)
        {
            Enemy enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
            enemy.GetComponent<FollowWaypoints>().waypoints = waypoints;
            enemy.GetComponent<FollowWaypoints>().castle = castle;
            _enemies.Add(enemy);
            enemyCountText.text = _enemies.Count.ToString();
        }
    }

    public void MoveEnemies()
    {
        isStarted = true;
        enemyCountText.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
