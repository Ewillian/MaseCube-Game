using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public float moveSpeed = 1.5f;
    public Transform[] patrolPoints;
    private int currentPoint;

	// Use this for initialization
	void Start () {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,patrolPoints[currentPoint].position, Time.deltaTime * moveSpeed);
        }
        if(currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }
	}
}
