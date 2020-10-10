using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandTurtleAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.root.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {

        isMoving = (rb.velocity.magnitude > 0.1f) ? true : false;
        anim.SetBool("isMoving", isMoving);
    }
}
