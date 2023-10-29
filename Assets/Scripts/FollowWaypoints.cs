using System;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    public GameObject[] waypoints = new GameObject[5];
    private int _currentWaypoint;
    [SerializeField] public Castle castle;
    [SerializeField] private float distance = 0.01f;
    [SerializeField] public Enemy enemy;
    [SerializeField] public GameObject settings;

    private SpawnEnemy _spawner;
    
    private void Start()
    {
        _spawner = FindObjectOfType<SpawnEnemy>();
    }

    void Update()
    {
        if (_spawner.isStarted)
        {
            if (Vector2.Distance(transform.position, waypoints[_currentWaypoint].transform.position) < distance)
                _currentWaypoint++;
            if (_currentWaypoint >= waypoints.Length){
                castle.hp -= enemy.attack;
                Destroy(gameObject);
                return;
            }
            transform.LookAt(waypoints[_currentWaypoint].transform);
            Transform transform1;
            (transform1 = transform).Translate(0, 0, enemy.speed * Time.deltaTime);
            transform1.eulerAngles = new Vector3(0, 0, transform1.eulerAngles.z);
        }
    }
}