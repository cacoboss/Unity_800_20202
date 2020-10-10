using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.transform.root.gameObject;
        if(obj.CompareTag("Enemy"))
            Destroy(obj);
    }
}
