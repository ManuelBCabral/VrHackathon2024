using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private GameObject gameMaster;
    private Transform target;
    private int pointIndex = 0;
    

    void Start()
    {
        target = WayPoints.waypoints[0];
        gameMaster = GameObject.Find("GameMaster");
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
            gameMaster.GetComponent<WaveSpawner>().LoseHealth();
            Console.WriteLine("Something reached the end!");
            Destroy(gameObject);
            return;
        }
        pointIndex++;
        target = WayPoints.waypoints[pointIndex];
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "End")
        {

            Destroy(this);


        }
    }
}
