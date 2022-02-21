using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GrannyMovement;


public class GrannyAttack : MonoBehaviour
{
    private Animator grannyAnimator;

    public Collider2D grannySlamHitBox;
    public PlayerCollisions playerCollisions;
    public SlamFieldSetTransform slamFieldSetTransform;

    private float waittime = 1f;
    public float maxWaitTime;
    public float minWaitTime;
    

    private void Awake()
    {
        grannyAnimator = GetComponent<Animator>();
    }

    private void Start()
    {
        waittime = Random.Range(minWaitTime, maxWaitTime);
        Debug.Log("Waittime " + waittime);
        Invoke("CoroutineSet", waittime);
    }

    private void CoroutineSet()
    {
        StartCoroutine(TriggerGrannyAttack());


    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GrannyAttackExecute();       
        }
    }*/
    private void GrannyAttackExecute()
    {
        Debug.Log("Granny attacks");
        grannyAnimator.SetBool("isAttacking", true);
        grannyIsChasing = false;
        
    }

    private void CheckForCollision()
    {
       // Debug.Log("CheckForCollision called");
        //Make Collider Check for damage
        
        grannyAnimator.SetBool("isAttacking", false);
        grannyIsChasing = true;
        slamFieldSetTransform.SetTransform(this.transform.position.x);
        playerCollisions.CheckForOverlapSlamDunk();

    }

    private IEnumerator TriggerGrannyAttack()
    {
        while (true)
        {
            GrannyAttackExecute();
            waittime = Random.Range(minWaitTime, maxWaitTime);
            Debug.Log("Waittime " + waittime);
            yield return new WaitForSeconds(waittime);
        }
    }

    
    






}
