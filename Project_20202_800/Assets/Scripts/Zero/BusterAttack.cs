using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterAttack : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject obj = other.transform.root.gameObject;
        if(obj.CompareTag("Enemy"))
            Destroy(obj);
        Destroy(this);
    }
}
