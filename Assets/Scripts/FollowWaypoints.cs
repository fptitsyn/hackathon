using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour{
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    [SerializeField] public float speed = 4f;
    [SerializeField] private float distance = 0.01f;
    [SerializeField] private Castle castle;

    void Update(){
        if (Vector2.Distance(this.transform.position, waypoints[currentWaypoint].transform.position) < distance)
            currentWaypoint++;
        if (currentWaypoint >= waypoints.Length){
            castle.hp--;
            Destroy(this.gameObject);
            return;
        }
        this.transform.LookAt(waypoints[currentWaypoint].transform);
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
