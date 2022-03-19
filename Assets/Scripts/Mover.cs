using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody physic;

    [SerializeField] int speed; 

    // Start is called before the first frame update
    void Start()
    {
        physic = GetComponent<Rigidbody>(); 

        physic.velocity = transform.forward * speed;
    }

    
    
}
