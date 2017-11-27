using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter : MonoBehaviour {

    public enum PlayerType
    {
        Human, AI
    };


    public static float MaxHealth = 100f;

    public float health = MaxHealth;
    public string fighterName;
    public fighter oponent;
    public PlayerType player;

    protected Animator animator;
    private Rigidbody myBody;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("health", healthPercent);	

        if(oponent != null) 
        {
            animator.SetFloat("oponent_health", oponent.healthPercent);
        } else {
            animator.SetFloat("oponent_health", 1);
        }

        //apply controls only for human
        if(player == PlayerType.Human) { UpdateHumanInput(); }
	}

    public void UpdateHumanInput()
    {
        
         // if the player moving in positive axis ... walk forward
        if(Input.GetAxis("Horizontal") > 0.1)
        {
            animator.SetBool("isWalking", true);
        } else {
            animator.SetBool("isWalking", false);
        }

        // if the player moving in negative axis ... walk backwords
        if (Input.GetAxis("Horizontal") < -0.1)
        {
            animator.SetBool("isWalkingB", true);
        } else {
            animator.SetBool("isWalkingB", false);
        }
        
        // if player clicked the attack keys the meant animation will play
        if (Input.GetKeyDown(KeyCode.K)) { animator.SetTrigger("meleeHorz"); }
        if (Input.GetKeyDown(KeyCode.L)) { animator.SetTrigger("kickv1"); }


    }



    //getters
    public float healthPercent { get { return health / MaxHealth; } }       //getting the healt as perentage
    public Rigidbody body { get { return this.myBody; } }                   // getting a refrence to my player body
}
