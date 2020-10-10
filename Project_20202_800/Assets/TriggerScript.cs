using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He entrado en contacto con algo:");
        Debug.Log("Con lo que choque es:" + collision.gameObject.name);

        Destroy(collision.gameObject);
    }
}
