using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour{
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    [SerializeField] private float distance = 0.01f;
    [SerializeField] public Castle castle;
    [SerializeField] public Enemy enemy;

    void Update(){
        if (Vector2.Distance(this.transform.position, waypoints[currentWaypoint].transform.position) < distance)
            currentWaypoint++;
        if (currentWaypoint >= waypoints.Length){
            castle.hp -= enemy.attack;
            Destroy(this.gameObject);
            return;
        }
        this.transform.LookAt(waypoints[currentWaypoint].transform);
        this.transform.Translate(0, 0, enemy.speed * Time.deltaTime);
        this.transform.eulerAngles = new Vector3(0, this.transform.eulerAngles.y, 0);
    }
}
