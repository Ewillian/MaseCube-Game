﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float moveSpeed = 3f;
    private Vector3 input;
    private Vector3 spawn;
    public GameObject deathParticle;
    public int countCoin = 0;
    public int deathCount = 0;
    

    void Start () {
        spawn = transform.position;
    }
	
	void Update () {
        input = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate(input * Time.deltaTime * moveSpeed);

        if (transform.position.y < -2)
        {
            Die();

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Enemy")
        {
            Die();
            deathCount += 1;
        }

        if (other.transform.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            countCoin += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            GameManager.completeLevel();
        }
    }

    void Die()
    {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
        transform.position = spawn; 
    }

}