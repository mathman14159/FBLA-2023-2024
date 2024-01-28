using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    

    [Header("For JumpAttack")]
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float jumpHight;
    [SerializeField] Transform player;
    [SerializeField] Transform groundCheck;
    [SerializeField] Vector2 boxSize;
    public Rigidbody2D enemyRB;
    private bool isGrounded;
    

    // Update is called once per frame
    void Update()
    {
        if(patrolDestination == 0 & isGrounded)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                patrolDestination = 1;
            }
        }

         if(patrolDestination == 1 & isGrounded)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                patrolDestination = 0;
            }
        }

        isGrounded = Physics2D.OverlapBox(groundCheck.position, boxSize, 0, groundLayer);
        if (Input.GetKeyDown(KeyCode.P))
        {
            JumpAttack();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        JumpAttack();
    }
    
    

    void JumpAttack()
    {
        float distanceFromPlayer = player.position.x - transform.position.x;

        if (isGrounded)
        {
            enemyRB.AddForce(new Vector2(distanceFromPlayer, jumpHight), ForceMode2D.Impulse);
        }
    }

   

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(groundCheck.position, boxSize);
    }
}