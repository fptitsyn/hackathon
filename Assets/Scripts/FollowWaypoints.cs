using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    private int _currentWaypoint;
    [SerializeField] private float distance = 0.01f;
    [SerializeField] public Enemy enemy;
    [SerializeField] public GameObject settings;

    void Update(){
        if (!settings.GetComponent<Level1Script>().isPlayGame)
            return;
        if (Vector2.Distance(transform.position, waypoints[_currentWaypoint].transform.position) < distance)
            _currentWaypoint++;
        if (_currentWaypoint >= waypoints.Length){
            settings.GetComponent<Level1Script>().castle.hp -= enemy.attack;
            Destroy(gameObject);
            return;
        }
        this.transform.LookAt(waypoints[_currentWaypoint].transform);
        this.transform.Translate(0, 0, GetComponentInParent<Enemy>().speed * Time.deltaTime);
        this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z);
    }
}