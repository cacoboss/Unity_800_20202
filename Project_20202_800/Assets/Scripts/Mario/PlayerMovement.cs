using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movX, movY;
    private bool jump;
    private Vector2 forceVector;
    public Animator anim;

    public float forceMultiplier, jumpMultiplier;

    private Rigidbody2D rb;

    // Jump Limit
    // Raycast, OverlapCircle
    private bool canJump = false;
    private Collider2D groundCollider;
    private byte stateOfJumps;
    private RaycastHit2D[] raycastHits = new RaycastHit2D[2];

    public bool jumpSelector;
    public Transform[] checkPoint;
    public LayerMask layers;
    public float[] checkRadius;
    public byte numOfJumps;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stateOfJumps = numOfJumps;
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        jump = Input.GetButtonDown("Jump");

        anim.SetFloat("Speed_X", Mathf.Abs(movX));
        

        if(movX < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
           
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (jumpSelector) 
        {
            if (groundCollider != null)
            {
                canJump = true;
                stateOfJumps = numOfJumps;
            }
            else
            {
                canJump = false;
            }
        }
        else
        {
            if(raycastHits[0]  || raycastHits[1] )
            {
                canJump = true;
                stateOfJumps = numOfJumps;
            }
            else
            {
                canJump = false;
            }
        }

        if(Input.GetButtonDown("Fire1"))
            anim.SetTrigger("Attack");
        if(Input.GetButtonDown("Fire2"))
            anim.SetTrigger("Buster");
        
    }

    private void FixedUpdate()
    {
        

        forceVector = new Vector2(movX, 0f) * forceMultiplier;

        rb.AddForce(forceVector, ForceMode2D.Force);

        if (jump)
        {
            if (canJump || stateOfJumps > 0)
            {
                rb.AddForce(Vector2.up * jumpMultiplier, ForceMode2D.Impulse);
                stateOfJumps -= 1;
            } 
        }

        groundCollider = Physics2D.OverlapCircle((Vector2)checkPoint[0].position, checkRadius[0], layers);

        raycastHits[0] = Physics2D.Raycast((Vector2)checkPoint[1].position, Vector2.down, checkRadius[1], layers);
        raycastHits[1] = Physics2D.Raycast((Vector2)checkPoint[2].position, Vector2.down, checkRadius[1], layers);
        //Debug.Log(collider);
    }
}
