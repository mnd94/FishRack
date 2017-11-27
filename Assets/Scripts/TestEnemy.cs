using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour {

    public float current_health;
    public float max_health;

    //for Simulation
    private float timer = 5;



	// Use this for initialization
	void Start () {
        current_health = max_health;	
	}
	
	// Update is called once per frame
	void Update () {

        //for Simulation
        timer -= 0.1f;
        if(timer < 0)
        {
            Debug.Log(current_health.ToString());
            timer = 5;
        }
	}

    public void TakeDamage(float amount)
    {
        if(current_health <= 0)
        {
            Debug.Log("isDead");
            current_health = 0;
        } else
            current_health += amount;
    }


}
