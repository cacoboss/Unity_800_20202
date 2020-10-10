using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float velocidadRotacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorRotacion = new Vector3(0f, 0f, velocidadRotacion) * Time.deltaTime;
        transform.Rotate(vectorRotacion);
    }
}
