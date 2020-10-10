using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterInstantiate : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
    }
    
}
