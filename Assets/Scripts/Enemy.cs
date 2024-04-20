using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int pointIndex = 0;

    void Start()
    {
        target = WayPoints.waypoints[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);

        if(Vector3.Distance(transform.position, target.position) < .02f)
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint()
    {
        if(pointIndex >= WayPoints.waypoints.Length-1)
        {
            Destroy(gameObject);
        }
        pointIndex++;
        target = WayPoints.waypoints[pointIndex];
    }
}
