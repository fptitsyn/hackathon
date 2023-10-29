using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    public GameObject[] waypoints = new GameObject[5];
    private int _currentWaypoint;
    [SerializeField] public Castle castle;
    [SerializeField] private float distance = 0.01f;
    [SerializeField] public Enemy enemy;
    [SerializeField] public GameObject settings;

    void Update(){
        if (Vector2.Distance(transform.position, waypoints[_currentWaypoint].transform.position) < distance)
            _currentWaypoint++;
        if (_currentWaypoint >= waypoints.Length){
            castle.hp -= enemy.attack;
            Destroy(gameObject);
            return;
        }
        transform.LookAt(waypoints[_currentWaypoint].transform);
        Transform transform1;
        (transform1 = transform).Translate(0, 0, GetComponentInParent<Enemy>().speed * Time.deltaTime);
        transform1.eulerAngles = new Vector3(0, 0, transform1.eulerAngles.z);
    }
}