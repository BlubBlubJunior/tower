using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waypoint : MonoBehaviour
{
    public Transform[] waypoints;
    [SerializeField] float maxspeed = 2f;
    int waypointindex = 0;
    private Transform lives;
    



    void Start()
    {
        transform.position = waypoints [waypointindex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
    }
    public void Move()
    {
       
        transform.position = Vector3.MoveTowards (transform.position,waypoints[waypointindex].transform.position,maxspeed * Time.deltaTime);
        
        if(transform.position == waypoints[waypointindex].transform.position)
        {
            waypointindex += 1;
        }
        
        if (waypointindex == waypoints.Length)
        {
            FindObjectOfType<health>().Health -= 1;
            Destroy(gameObject);
            
        }
    }
}
